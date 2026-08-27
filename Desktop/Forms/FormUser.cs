using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.User;
using BudgetBrainDesktop.UserControls.User.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.Forms
{
    public partial class FormUser : Form
    {
        private readonly FormLogin loginForm;
        private bool logoutInProgress = false;
        private bool allowClose = false;
        public FormUser(FormLogin loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm;

            btnDashBoard.Click += BtnDashBoardClick;
            btnEntries.Click += BtnEntriesClick;
            btnCategories.Click += BtnPlannerClick;
            btnPlanner.Click += BtnFeedbackClick;
            btnFeedback.Click += BtnSettingsClick;
            btnLogout.Click += BtnLogoutClick;
            //btnAdd.Click += BtnAddClick;
            this.FormClosing += FormUserFormClosing;

            ControlUserDashboard dashboard = new();

            LoadPage(dashboard, dashboard.PageTitle);

            btnDashBoard.Image = Properties.Resources.dashboard_icon;
            btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;

            btnEntries.Image = Properties.Resources.entries_icon;
            btnEntries.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntries.ImageAlign = ContentAlignment.MiddleLeft;

            btnCategories.Image = Properties.Resources.planner_icon;
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;

            btnPlanner.Image = Properties.Resources.feedback_icon;
            btnPlanner.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlanner.ImageAlign = ContentAlignment.MiddleLeft;

            btnFeedback.Image = Properties.Resources.settings_icon;
            btnFeedback.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFeedback.ImageAlign = ContentAlignment.MiddleLeft;

            btnLogout.Image = Properties.Resources.logout_icon;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
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

        private async void FormUserFormClosing(object? sender, FormClosingEventArgs e)
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
        private void BtnDashBoardClick(object? sender, EventArgs e)
        {
            ControlUserDashboard dashboard = new();
            LoadPage(dashboard, dashboard.PageTitle);
        }
        private void BtnEntriesClick(object? sender, EventArgs e)
        {
            ControlUserEntries entries = new();
            LoadPage(entries, entries.PageTitle);
        }
        private void BtnPlannerClick(object? sender, EventArgs e)
        {
            ControlUserPlanner planner = new();
            LoadPage(planner, planner.PageTitle);
        }
        private void BtnFeedbackClick(object? sender, EventArgs e)
        {
            ControlUserFeedback feedback = new();
            LoadPage(feedback, feedback.PageTitle);
        }
        private void BtnSettingsClick(object? sender, EventArgs e)
        {
            ControlUserSettings settings = new();
            LoadPage(settings, settings.PageTitle);
        }










    }
}
