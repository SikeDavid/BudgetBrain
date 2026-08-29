using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.Cards
{
    public partial class ControlUserCard : UserControl
    {
        private readonly int userId;
        private string currentStatus;
        public ControlUserCard(UserModel user)
        {
            InitializeComponent();
            btnSave.Click += BtnSaveClick;
            btnDelete.Click += BtnDeleteClick;
            

            userId = user.UserId;
            currentStatus = user.UserStatus.ToString();
            lblUsername.Text = user.Username;
            lblEmail.Text = user.Email;
            lblRole.Text = user.UserRole;
            //lblStatus.Text = user.UserStatus;
            cbStatus.Items.AddRange(
                ["active", "pending", "suspended"]);
            cbStatus.SelectedItem = currentStatus;
        }

        private async void BtnSaveClick(object? sender, EventArgs e)
        {
            string newStatus = cbStatus.SelectedItem.ToString();

            if (newStatus == currentStatus)
            {
                MessageBox.Show("User status not changed", "No change", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try
            {
                btnSave.Enabled = false;
                btnSave.Text = "Saving...";

                UserModel.Status body = new()
                {
                    UserStatus = newStatus
                };

                MessageModel response = await ApiService.PatchAsync<UserModel.Status>($"admin/users/{userId}/status", body);

                currentStatus = newStatus;
            }
            catch (Exception ex)
            {
                cbStatus.SelectedItem = currentStatus;
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
                btnSave.Text = "Save";
            }
        }

        private async void BtnDeleteClick(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Deleting {lblUsername.Text} user?", "Deleting user",
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
                btnDelete.Text = "Deleting...";

                await ApiService.DeleteAsync($"admin/users/{userId}/delete");

                Parent?.Controls.Remove(this);
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnDelete.Enabled = true;
                    btnDelete.Text = "Delete";
                }
            }
        }
    }
}
