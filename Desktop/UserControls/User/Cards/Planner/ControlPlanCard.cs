using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards.Planner
{
    public partial class ControlPlanCard : UserControl
    {
        private readonly int planId;
        private readonly int planStatus;
        private bool modify = false;
        public ControlPlanCard(PlannerModel plan, List<CategoriesModel> categories)
        {
            InitializeComponent();

            planId = plan.Id;
            planStatus = plan.Active;

            lblDescription.Text = plan.Description;
            lblAmount.Text = plan.Amount.ToString();
            lblDayofMonth.Text = plan.DayofMonth.ToString();
            lblType.Text = plan.Type;
            if (plan.Type == "income")
            {
                lblType.ForeColor = Color.FromArgb(36, 182, 110);
            }
            else
            {
                lblType.ForeColor = Color.FromArgb(244, 79, 80);
            }
            if (plan.Active == 1)
            {
                lblStatus.Text = "active";
                lblStatus.ForeColor = Color.FromArgb(36, 182, 110);
                btnDelete.Image = Resources.delete_icon;
            }
            else
            {
                lblStatus.Text = "inactive";
                lblStatus.ForeColor = Color.FromArgb(244, 79, 80);
                btnDelete.Image = Resources.restore_from_trash_icon;
            }
            btnModify.Text = "";
            btnModify.Image = Properties.Resources.modify_icon;
            btnModify.ImageAlign = ContentAlignment.MiddleCenter;
            btnModify.FlatAppearance.BorderSize = 0;

            btnDelete.Text = "";
            //btnDelete.Image = Properties.Resources.delete_icon;
            btnDelete.ImageAlign = ContentAlignment.MiddleCenter;
            btnModify.FlatAppearance.BorderSize = 0;

            tbDescription.Visible = false;
            tbAmount.Visible = false;
            nudDay.Visible = false;
            cbCategory.Visible = false;

            var activeCategories = categories.Where(c => c.inUse == 1).ToList();
            cbCategory.DisplayMember = nameof(CategoriesModel.Name);
            cbCategory.ValueMember = nameof(CategoriesModel.Id);
            cbCategory.DataSource = categories;
            cbCategory.SelectedValue = plan.CategoryId;

            btnDelete.Click += BtnDeleteClick;
            btnModify.Click += BtnModifyClick;
        }

        public event EventHandler? PlanChanged;

        private void BtnModifyClick(object? sender, EventArgs e)
        {
            modify = !modify;
            btnModify.Image = modify ? Resources.close_icon : Resources.modify_icon;

            btnDelete.Image = modify ? Resources.save_icon : Resources.delete_icon;
            if (modify)
            {
                btnDelete.Image = Resources.save_icon;
            }
            else
            {
                btnDelete.Image = planStatus == 1 ? Resources.delete_icon : Resources.restore_from_trash_icon;
            }

            lblDescription.Visible = !modify;
            lblAmount.Visible = !modify;
            lblDayofMonth.Visible = !modify;
            lblType.Visible = !modify;
            lblStatus.Visible = !modify;

            tbDescription.Visible = modify;
            tbAmount.Visible = modify;
            nudDay.Visible = modify;
            cbCategory.Visible = modify;

            tbDescription.Text = lblDescription.Text;
            tbAmount.Text = lblAmount.Text;
            nudDay.Value = Convert.ToInt32(lblDayofMonth.Text);
        }

        private async void BtnDeleteClick(object? sender, EventArgs e)
        {
            if (modify)
            {
                // save
                try
                {
                    btnDelete.Enabled = false;

                    PlannerModel.Post body = new()
                    {
                        CategoryId = (int)cbCategory.SelectedValue,
                        Description = tbDescription.Text,
                        Amount = Math.Abs(Convert.ToInt32(tbAmount.Text)),
                        DayofMonth = Convert.ToInt32(nudDay.Value)
                    };

                    MessageModel response = await ApiService.PatchAsync<PlannerModel.Post>($"planner/{planId}", body);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnDelete.Enabled = true;
                    PlanChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                //delete
                DialogResult result = MessageBox.Show(
                    $"{(planStatus == 1 ? "Deleting" : "Restore")} {lblDescription.Text} plan?", planStatus == 1 ? "Deleting": "Restore",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    btnDelete.Enabled = false;

                    await ApiService.PatchAsync($"planner/{planId}/status");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnDelete.Enabled = true;
                    PlanChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
