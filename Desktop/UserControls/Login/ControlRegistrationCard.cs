using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;

namespace BudgetBrainDesktop.UserControls.User.Cards.LoginReg
{
    public partial class ControlRegistrationCard : UserControl
    {
        //bool validUser = false;
        bool validEmail = false;
        bool validPass = false;
        public ControlRegistrationCard()
        {
            InitializeComponent();

            this.Load += ControlRegistrationCardLoad;
            txtUsername.TextChanged += TxtUsernameTextChanged;
            txtEmail.TextChanged += TxtEmailTextChanged;
            txtPassword.TextChanged += TxtPasswordTextChanged;
            btnRegistration.Click += BtnRegistrationClick;
        }

        private async void BtnRegistrationClick(object? sender, EventArgs e)
        {
            try
            {
                btnRegistration.Enabled = false;
                //btnRegistration.Text = "Registration...";

                RegistrationModel body = new RegistrationModel { Username = txtUsername.Text, Email = txtEmail.Text, Password = txtPassword.Text };

                MessageModel response = await ApiService.PostAsync<RegistrationModel, MessageModel>("auth/registration", body);

                if (response.Message == "Registration successful")
                {
                    MessageBox.Show(response.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ControlRegistrationCardLoad(object? sender, EventArgs e)
        {
            RegistrationButtonEnable();
        }

        private void TxtUsernameTextChanged(object? sender, EventArgs e)
        {
            RegistrationButtonEnable();
        }

        private void TxtEmailTextChanged(object? sender, EventArgs e)
        {
            validEmail = Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            RegistrationButtonEnable();
        }

        private void TxtPasswordTextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblRegexChar.Visible = true;
                lblRegexlow.Visible = true;
                lblRegexUp.Visible = true;
                lblRegexNum.Visible = true;
                lblRegexSpec.Visible = true;
            }
            else
            {
                lblRegexChar.Visible = false;
                lblRegexlow.Visible = false;
                lblRegexUp.Visible = false;
                lblRegexNum.Visible = false;
                lblRegexSpec.Visible = false;
            }
            //bool checkVisible = !string.IsNullOrWhiteSpace(txtPassword.Text);

            //lblRegexChar.Visible = true;
            //lblRegexlow.Visible = true;
            //lblRegexUp.Visible = true;
            //lblRegexNum.Visible = true;
            //lblRegexSpec.Visible = true;

            //if (!checkVisible) return;
            bool regexChar = Regex.IsMatch(txtPassword.Text, @".{8,}");
            bool regexLow = Regex.IsMatch(txtPassword.Text, @"[a-z]");
            bool regexUp = Regex.IsMatch(txtPassword.Text, @"[A-Z]");
            bool regexNum = Regex.IsMatch(txtPassword.Text, @"[0-9]");
            bool regexSpec = Regex.IsMatch(txtPassword.Text, @"[#?!@$%^&*+\-]");

            CheckRule(lblRegexChar, regexChar);
            CheckRule(lblRegexlow, regexLow);
            CheckRule(lblRegexUp, regexUp);
            CheckRule(lblRegexNum, regexNum);
            CheckRule(lblRegexSpec, regexSpec);

            validPass = regexChar && regexLow && regexUp && regexNum && regexSpec;
            RegistrationButtonEnable();
            //if (Regex.IsMatch(txtPassword.Text, @".{8,}"))
            //{
            //    lblRegexChar.ForeColor = Color.DeepSkyBlue;
            //}
            //if (Regex.IsMatch(txtPassword.Text, @"[a-z]"))
            //{
            //    lblRegexlow.ForeColor = Color.DeepSkyBlue;
            //}
            //if (Regex.IsMatch(txtPassword.Text, @"[A-Z]"))
            //{
            //    lblRegexUp.ForeColor = Color.DeepSkyBlue;
            //}
            //if (Regex.IsMatch(txtPassword.Text, @"[0-9]"))
            //{
            //    lblRegexNum.ForeColor = Color.DeepSkyBlue;
            //}
            //if (Regex.IsMatch(txtPassword.Text, @"[#?!@$%^&*+\-]"))
            //{
            //    lblRegexSpec.ForeColor = Color.DeepSkyBlue;
            //}
        }

        private void CheckRule(Label label, bool valid)
        {
            if (valid)
            {
                label.ForeColor = Color.Green;
            }
            else
            {
                label.ForeColor = Color.Red;
            }
        }
        private void RegistrationButtonEnable()
        {
            btnRegistration.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) 
                && validPass 
                && validEmail;
        }
    }
}
