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

namespace BudgetBrainDesktop.UserControls.User.Cards.Categories
{
    public partial class ControlCategoriesCard : UserControl
    {
        private readonly int categoryId;
        private readonly int categoryStatus;
        public ControlCategoriesCard(CategoriesModel category)
        {
            InitializeComponent();

            panelModify.Visible = false;
            Height = 83;
            btnModify.Text = "";
            btnModify.Image = Resources.arrow_downward_icon;

            categoryId = category.Id;
            categoryStatus = category.inUse;

            lblName.Text = category.Name;
            lblType.Text = category.Type;
            btnSave.Text = "";
            btnSave.Image = Resources.save_icon;
            btnDelete.Text = "";
            if (category.inUse == 0)
            {
                btnDelete.Image = Resources.restore_from_trash_icon;
            }
            else
            {
                btnDelete.Image = Resources.delete_icon;
            }

            tbName.Text = category.Name;
            cbType.Items.AddRange(["income", "expense",]);
            cbType.SelectedItem = category.Type;

            btnDelete.Click += BtnDeleteClick;
            btnModify.Click += BtnModify_Click;
            btnSave.Click += BtnSaveClick;

        }
        public event EventHandler? CategoryChanged;

        private async void BtnSaveClick(object? sender, EventArgs e)
        {
            if (tbName.Text == lblName.Text && cbType.Text == lblType.Text)
            {
                MessageBox.Show("Nothing to change", "No change", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try
            {
                btnSave.Enabled = false;

                CategoriesModel body = new()
                {
                    Name = tbName.Text,
                    Type = cbType.Text
                };

                MessageModel response = await ApiService.PatchAsync<CategoriesModel>($"categories/{categoryId}", body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Sikertelen módosítás",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
                //MessageBox.Show(
                //    "Save successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void BtnModify_Click(object? sender, EventArgs e)
        {
            panelModify.Visible = !panelModify.Visible;
            Height = panelModify.Visible ? 166 : 83;
            btnModify.Text = "";
            btnModify.Image = panelModify.Visible ? Resources.arrow_upward_icon : Resources.arrow_downward_icon;
        }

        private async void BtnDeleteClick(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"{(categoryStatus == 1 ? "Removing" : "Restore")} {lblName.Text} category", $"{(categoryStatus == 1 ? "Removing" : "Restore")} category",
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

                await ApiService.PatchAsync($"categories/{categoryId}/status");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDelete.Enabled = true;
                CategoryChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
