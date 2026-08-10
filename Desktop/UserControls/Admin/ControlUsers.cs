using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using BudgetBrainDesktop.Models;

namespace BudgetBrainDesktop.UserControls
{
    public partial class ControlUsers : UserControl
    {
        public string PageTitle { get; } = "Users";
        private List<UserModel> users = new();
        public ControlUsers()
        {
            InitializeComponent();
            this.Load += ControlUsersLoad;
            tbSearch.TextChanged += TbSearchTextChanged;
        }

        private async void ControlUsersLoad(object? sender, EventArgs e)
        {
            await LoadUsersAsync();
        }
        private void TbSearchTextChanged(object? sender, EventArgs e)
        {
            FilterUsers();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                users = await ApiService.GetAsync<List<UserModel>>("admin/getusersdata");

                DisplayUsers(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayUsers(IEnumerable<UserModel> usersToDisplay)
        {
            panelUserContent.Controls.Clear();

            foreach (UserModel user in usersToDisplay)
            {
                ControlUserCard card = new ControlUserCard(user);
                panelUserContent.Controls.Add(card);
            }
        }

        private void FilterUsers()
        {
            string searchText = tbSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayUsers(users);
                return;
            }

            List<UserModel> filteredUsers = users
                .Where(user =>
                    user.Username.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    user.Email.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                ).ToList();

            DisplayUsers(filteredUsers);
        }
    }
}
