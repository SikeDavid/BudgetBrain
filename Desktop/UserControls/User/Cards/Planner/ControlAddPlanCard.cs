using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards.Planner
{
    public partial class ControlAddPlanCard : UserControl
    {
        public ControlAddPlanCard(List<CategoriesModel> categories)
        {
            InitializeComponent();

            btnSave.Text = "";
            btnSave.Image = Resources.save_icon;

            var activeCategories = categories.Where(c => c.inUse == 1).ToList();
            cbCategory.DisplayMember = nameof(CategoriesModel.Name);
            cbCategory.ValueMember = nameof(CategoriesModel.Id);
            cbCategory.DataSource = activeCategories;

            btnSave.Click += BtnSaveClick;
        }

        private async void BtnSaveClick(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCategory.SelectedValue);
            int amount = Convert.ToInt32(tbAmount.Text);
            string description = tbDescription.Text;
            int day = Convert.ToInt32(nudDay.Value);

            PlannerModel.Post body = new()
            {
                CategoryId = id,
                Amount = amount,
                Description = description,
                DayofMonth = day
            };

            try
            {
                btnSave.Enabled = false;

                MessageModel response = await ApiService.PostAsync<PlannerModel.Post, MessageModel>("planner", body);

                MessageBox.Show(
                    response.Message,
                    "Sikeres mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Sikertelen mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
                this.Dispose();
                EntryChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? EntryChanged;
    }
}
