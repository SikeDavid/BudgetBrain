using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
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
        private List<CategoriesModel> categories = new();
        private bool activeChecked = false;
        private ControlAddPlanCard? addControl;
        public ControlUserPlanner()
        {
            InitializeComponent();
            cbActive.Checked = activeChecked;

            this.Load += ControlUserPlannerLoad;
            cbActive.CheckedChanged += RbActiveCheckedChanged;
            btnAddPlan.Click += BtnAddPlanClick;
        }

        private void BtnAddPlanClick(object? sender, EventArgs e)
        {
            if (addControl == null)
            {
                btnAddPlan.Image = Resources.close_icon;
                btnAddPlan.BackColor = Color.FromArgb(244, 79, 80);

                cbActive.Visible = false;

                addControl = new(categories);
                addControl.Dock = DockStyle.Fill;
                //addControl.EntryChanged += CardEntryChanged;
                panelContent.Controls.Add(addControl);
                addControl.BringToFront();
            }
            else
            {
                btnAddPlan.Image = Resources.add_icon;
                btnAddPlan.BackColor = Color.FromArgb(36, 182, 110);

                cbActive.Visible = true;

                panelContent.Controls.Remove(addControl);
                addControl.Dispose();
                addControl = null;
            }
        }

        private async void RbActiveCheckedChanged(object? sender, EventArgs e)
        {
            activeChecked = !activeChecked;
            await LoadPlansAsync();
        }

        private async void ControlUserPlannerLoad(object? sender, EventArgs e)
        {
            await LoadCategoriesAsync();
            await LoadPlansAsync();
        }

        private async Task LoadPlansAsync()
        {
            panelContent.Controls.Clear();
            try
            {
                plans = await ApiService.GetAsync<List<PlannerModel>>("planner");

                if (cbActive.Checked)
                {
                    var acivePlans = plans.Where(c => c.Active == 1).ToList();
                    DisplayEntry(acivePlans);
                }
                else
                {
                    DisplayEntry(plans);
                }
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
                ControlPlanCard card = new(plan, categories);

                card.Dock = DockStyle.None;
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                card.Margin = new Padding(5);
                card.PlanChanged += CardPlanChanged;
                panelContent.Controls.Add(card);
            }
        }

        private async void CardPlanChanged(object? sender, EventArgs e)
        {
            await LoadPlansAsync();
        }
        private async Task LoadCategoriesAsync()
        {
            try
            {
                categories = await ApiService.GetAsync<List<CategoriesModel>>(
                    $"categories");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
