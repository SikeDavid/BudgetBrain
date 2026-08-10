using BudgetBrainDesktop.Forms;
using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards.LoginReg
{
    public partial class ControlLoginCard : UserControl
    {
        public ControlLoginCard()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            lblError.Text = string.Empty;
            btnLogin.Enabled = false;

            btnLogin.Click += BtnLoginClick;
            txtPassword.TextChanged += TxtPasswordTextChanged;
            txtUsername.TextChanged += TxtUsernameTextChanged;
        }

        private void TxtUsernameTextChanged(object? sender, EventArgs e)
        {
            LoginButtonEnable();
        }

        private void TxtPasswordTextChanged(object? sender, EventArgs e)
        {
            LoginButtonEnable();
        }
        private void LoginButtonEnable()
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private async void BtnLoginClick(object? sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            btnLogin.Enabled = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Logging in...";

                LoginModel.LoginRequest body = new LoginModel.LoginRequest { Username = username, Password = password };

                LoginModel.LoginResponse response = await ApiService.PostAsync<LoginModel.LoginRequest, LoginModel.LoginResponse>("auth/login", body);

                TokenStorage.AccessToken = response.AccessToken;
                TokenStorage.RefreshToken = response.RefreshToken;

                //MessageBox.Show("Sikeres bejelentkezés", caption: "Sikeres bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdmin admin = new FormAdmin();
                FormUser user = new();

                if (response.User.Role == "admin")
                {
                    admin.Show();
                }
                else
                {
                    user.Show();
                }
                Hide();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
                //MessageBox.Show($"Üdv, {loginResponse.User?.Username}!");
            }
        }
    }
}
