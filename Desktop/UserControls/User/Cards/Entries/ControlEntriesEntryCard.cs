using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BudgetBrainDesktop.UserControls.User.Cards
{
    public partial class ControlEntriesEntryCard : UserControl
    {
        private readonly int entryId;
        private bool paid;
        private bool modify = false;
        public ControlEntriesEntryCard(EntriesModel entry, List<CategoriesModel> categories)
        {
            InitializeComponent();

            entryId = entry.Id;
            paid = Convert.ToBoolean(entry.Completed);

            lblDate.Text = entry.Date;
            lblType.Text = entry.Type;
            lblDescription.Text = entry.Description;
            lblCategory.Text = entry.Category;
            lblAmount.Text = entry.Amount.ToString();

            if (entry.Completed == 0)
            {
                lblAmount.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (entry.Amount < 0)
            {
                lblAmount.ForeColor = Color.FromArgb(244, 79, 80);
            }
            else if (entry.Amount >= 0)
            {
                lblAmount.Text = $"+{entry.Amount.ToString()}";
                lblAmount.ForeColor = Color.FromArgb(36, 182, 110);
            }

            if (entry.Type == "income")
            {
                lblType.ForeColor = Color.FromArgb(36, 182, 110);
            }
            else if (entry.Type == "expense")
            {
                lblType.ForeColor = Color.FromArgb(244, 79, 80);
            }

            btnPaid.Text = "";
            btnPaid.Image = paid ? Resources.check_icon : Resources.money_bag_icon;

            btnModify.Text = "";
            btnModify.Image = Resources.modify_icon;
            btnDelete.Text = "";
            btnDelete.Image = Resources.delete_icon;

            dtpModify.Visible = false;
            dtpModify.Format = DateTimePickerFormat.Custom;
            dtpModify.CustomFormat = "yyyy-MM-dd";
            dtpModify.Value = DateTime.Parse(entry.Date);
            tbModifyDescription.Visible = false;
            tbModifyDescription.Text = entry.Description;
            cbModifyCategory.Visible = false;

            var activeCategories = categories.Where(c => c.inUse == 1).ToList();
            cbModifyCategory.DisplayMember = nameof (CategoriesModel.Name);
            cbModifyCategory.ValueMember = nameof (CategoriesModel.Id);
            cbModifyCategory.DataSource = categories;
            cbModifyCategory.SelectedValue = entry.CategoryId;

            tbModifyAmount.Visible = false;
            tbModifyAmount.Text = Convert.ToString(entry.Amount);

            btnPaid.Click += BtnPaidClick;
            btnModify.Click += BtnModifyClick;
            btnDelete.Click += BtnDelete_Click;
        }

        public event EventHandler? EntryChanged;

        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (modify)
            {
                try
                {
                    btnDelete.Enabled = false;

                    EntriesModel.Post body = new()
                    {
                        Date = dtpModify.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                        Description = tbModifyDescription.Text,
                        Categoryid = (int)cbModifyCategory.SelectedValue,
                        Amount = Math.Abs(Convert.ToInt32(tbModifyAmount.Text))
                    };

                    MessageModel response = await ApiService.PatchAsync<EntriesModel.Post>($"entries/{entryId}", body);

                    modify = !modify;
                    btnModify.Image = modify ? Resources.close_icon : Resources.modify_icon;

                    btnDelete.Image = modify ? Resources.save_icon : Resources.delete_icon;

                    lblDate.Visible = !modify;
                    lblType.Visible = !modify;
                    lblDescription.Visible = !modify;
                    lblCategory.Visible = !modify;
                    lblAmount.Visible = !modify;

                    dtpModify.Visible = modify;
                    tbModifyDescription.Visible = modify;
                    cbModifyCategory.Visible = modify;
                    tbModifyAmount.Visible = modify;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    EntryChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            MessageBox.Show("Delete");
            return;
        }

        private async void BtnModifyClick(object? sender, EventArgs e)
        {
            modify = !modify;
            btnModify.Image = modify ? Resources.close_icon : Resources.modify_icon;

            btnDelete.Image = modify ? Resources.save_icon : Resources.delete_icon;

            lblDate.Visible = !modify;
            lblType.Visible = !modify;
            lblDescription.Visible = !modify;
            lblCategory.Visible = !modify;
            lblAmount.Visible = !modify;

            dtpModify.Visible = modify;
            tbModifyDescription.Visible = modify;
            cbModifyCategory.Visible = modify;
            tbModifyAmount.Visible = modify;


        }

        private async void BtnPaidClick(object? sender, EventArgs e)
        {
            btnPaid.Enabled = false;

            try
            {
                await ApiService.PatchAsync($"entries/{entryId}/complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modify failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPaid.Enabled = true;
                paid = !paid;
                btnPaid.Image = paid ? Resources.check_icon : Resources.money_bag_icon;
            }
        }
    }
}
