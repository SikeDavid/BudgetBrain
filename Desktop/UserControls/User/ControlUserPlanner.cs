using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.User.Cards;
using BudgetBrainDesktop.UserControls.User.Cards.Planner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User
{
    public partial class ControlUserPlanner : UserControl
    {
        public string PageTitle { get; } = "Planner";
        private List<PlannerModel> plans = new();
        public ControlUserPlanner()
        {
            InitializeComponent();

            this.Load += ControlUserPlannerLoad;
        }

        private async void ControlUserPlannerLoad(object? sender, EventArgs e)
        {
            await LoadPlansAsync();
        }

        private async Task LoadPlansAsync()
        {
            try
            {
                plans = await ApiService.GetAsync<List<PlannerModel>>("planner");

                DisplayEntry(plans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //panelContent.Controls.Clear();
            }
        }

        private void DisplayEntry(IEnumerable<PlannerModel> plansToDisplay)
        {
            panelContent.Controls.Clear();

            foreach (PlannerModel plan in plansToDisplay)
            {
                ControlPlanCard card = new(plan);

                card.Dock = DockStyle.None;
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                card.Margin = new Padding(5);
                panelContent.Controls.Add(card);
            }
        }
    }
}
