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
                categories = await ApiService.GetAsync<List<CategoriesModel>>("categories");

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

            var activeCategories = categories.Where(c => c.inUse == 1).ToList();
            var inactiveCategories = categories.Where(c => c.inUse == 0).ToList();

            //foreach (var category in categoriesToDisplay)
            //{
            //    ControlCategoriesCard card = new(category);

            //    card.Dock = DockStyle.None;
            //    card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            //    card.Margin = new Padding(5);
            //    panelContent.Controls.Add(card);
            //}
            foreach (CategoriesModel category in activeCategories)
            {
                ControlCategoriesCard card = new(category);
                card.Margin = new Padding(5);
                card.CategoryChanged += Card_CategoryChanged;
                panelContent.Controls.Add(card);
            }

            if (inactiveCategories.Count > 0)
            {
                Panel separator = new();
                separator.Height = 2;
                separator.Width = panelContent.ClientSize.Width - 20;
                separator.BackColor = Color.Gray;
                separator.Margin = new Padding(5, 15, 5, 15);
                panelContent.Controls.Add(separator);
            }

            foreach (CategoriesModel category in inactiveCategories)
            {
                ControlCategoriesCard card = new(category);
                card.BackColor = Color.Gray;
                card.Margin = new Padding(5);
                card.CategoryChanged += Card_CategoryChanged;
                panelContent.Controls.Add(card);
            }
        }

        private async void Card_CategoryChanged(object? sender, EventArgs e)
        {
            await LoadAsync();
        }
    }
}
