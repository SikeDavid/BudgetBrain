using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.User.Cards.Categories;
using BudgetBrainDesktop.UserControls.User.Cards.Planner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User
{
    public partial class ControlUserCategories : UserControl
    {
        public string PageTitle { get; } = "Categories";

        private List<CategoriesModel> categories = new();
        public ControlUserCategories()
        {
            InitializeComponent();

            //this.Load += ControlUserPlannerLoad;
            this.Load += ControlUserCategoriesLoad;
        }

        private async void ControlUserCategoriesLoad(object? sender, EventArgs e)
        {
            await LoadAsync();
        }

        private async Task LoadAsync()
        {
            try
            {
                categories = await ApiService.GetAsync<List<CategoriesModel>>("entries");

                DisplayEntry(categories);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayEntry(IEnumerable<CategoriesModel> categoriesToDisplay)
        {
            panelContent.Controls.Clear();

            foreach (var category in categoriesToDisplay)
            {
                ControlCategoriesCard card = new(category);

                //card.Dock = DockStyle.None;
                //card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                //card.Margin = new Padding(5);
                panelContent.Controls.Add(card);
            }
        }
        //private void DisplayEntry(IEnumerable<PlannerModel> plansToDisplay)
        //{
        //    panelContent.Controls.Clear();

        //    foreach (PlannerModel plan in plansToDisplay)
        //    {
        //        ControlPlanCard card = new(plan);

        //        card.Dock = DockStyle.None;
        //        card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        //        card.Margin = new Padding(5);
        //        panelContent.Controls.Add(card);
        //    }
        //}
    }
}
