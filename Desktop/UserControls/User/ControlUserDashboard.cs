using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.User.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User
{
    public partial class ControlUserDashboard : UserControl
    {
        public string PageTitle { get; } = "Dashboard";

        private DashboardModel data = new();
        public ControlUserDashboard()
        {
            InitializeComponent();

            this.Load += ControlUserDashboardLoad;
        }

        private async void ControlUserDashboardLoad(object? sender, EventArgs e)
        {
            await LoadDashboardAsync();
        }

        private async Task LoadDashboardAsync()
        {
            try
            {
                data = await ApiService.GetAsync<DashboardModel>("entries/dashboard");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lblBalance.Text = data.Balance.ToString();
                lblIncome.Text = data.Income.ToString();
                lblExpense.Text = data.Expense.ToString();

                if (data.Balance >= 0)
                {
                    lblBalance.ForeColor = Color.FromArgb(36, 182, 110);
                }


                foreach (EntriesModel entry in data.entry)
                {
                    ControlDashEntryCard card = new(entry);

                    card.Dock = DockStyle.None;
                    card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    card.Margin = new Padding(5);
                    panelContent.Controls.Add(card);
                }
            }
        }
    }
}
