using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.Forms
{
    public partial class FormAdmin : Form
    {
        private readonly FormLogin loginForm;
        private readonly ControlDashboard pageDashboard;
        private readonly ControlUsers pageUsers;
        private readonly ControlStatistics pageStatistics;
        private readonly ControlFeedback pageFeedback;

        private bool logoutInProgress = false;
        private bool allowClose = false;
        public FormAdmin(FormLogin loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm;

            pageDashboard = new ControlDashboard();
            pageUsers = new ControlUsers();
            pageStatistics = new ControlStatistics();
            pageFeedback = new ControlFeedback();

            LoadPage(pageDashboard, pageDashboard.PageTitle);

            this.FormClosing += FormAdminFormClosing;

            btnLogout.Click += BtnLogoutClick;
        }

        private async void BtnLogoutClick(object? sender, EventArgs e)
        {
            if (allowClose) return;
            //e.Cancel = true;
            if (logoutInProgress) return;
            logoutInProgress = true;
            btnLogout.Text = "Logging out...";

            try
            {
                TokenStorage.LogoutToken body = new()
                {
                    RefreshToken = TokenStorage.RefreshToken
                };

                await ApiService.PostAsync<TokenStorage.LogoutToken, MessageModel>(
                    "auth/logout", body);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Server error: {ex.Message}", "Logout error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TokenStorage.Clear();
                allowClose = true;
                loginForm.Show();
                Close();
            }
        }

        private async void FormAdminFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (allowClose) return;
            e.Cancel = true;
            if (logoutInProgress) return;
            logoutInProgress = true;

            try
            {
                TokenStorage.LogoutToken body = new()
                {
                    RefreshToken = TokenStorage.RefreshToken
                };

                await ApiService.PostAsync<TokenStorage.LogoutToken, MessageModel>(
                    "auth/logout", body);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Server error: {ex.Message}", "Logout error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TokenStorage.Clear();
                allowClose = true;
                Application.Exit();
            }
        }

        private void LoadPage(UserControl page, string title)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
            page.BringToFront();
            lblPageTitle.Text = title;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            LoadPage(pageDashboard, pageDashboard.PageTitle);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadPage(pageUsers, pageUsers.PageTitle);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            LoadPage(pageStatistics, pageStatistics.PageTitle);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            LoadPage(pageFeedback, pageFeedback.PageTitle);
        }
    }
}
