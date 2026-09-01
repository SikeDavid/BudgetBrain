using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards
{
    public partial class ControlAddEntryCard : UserControl
    {
        public string PageTitle { get; } = "Add";
        public List<CategoriesModel.Get> categories = new();
        public ControlAddEntryCard(List<CategoriesModel> categories)
        {
            InitializeComponent();

            this.Load += ControlAddEntryCardLoad;

            btnSave.Text = "";
            btnSave.Image = Resources.save_icon;

            var activeCategories = categories.Where(c => c.inUse == 1).ToList();
            cbCategory.DisplayMember = nameof(CategoriesModel.Name);
            cbCategory.ValueMember = nameof(CategoriesModel.Id);
            cbCategory.DataSource = activeCategories;

            btnSave.Click += BtnsaveClick;

        }

        public event EventHandler? EntryChanged;

        private async void BtnsaveClick(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCategory.SelectedValue);
            int amount = Convert.ToInt32(tbAmount.Text);
            string description = tbDescription.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            EntriesModel.Post body = new()
            {
                Categoryid = id,
                Amount = amount,
                Description = description,
                Date = date
            };

            try
            {
                btnSave.Enabled = false;

                MessageModel response = await ApiService.PostAsync<EntriesModel.Post, MessageModel>("entries", body);

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

        private async void ControlAddEntryCardLoad(object? sender, EventArgs e)
        {
            await LoadCategoriesAsync();
        }
        private async Task LoadCategoriesAsync()
        {
            try
            {
                categories = await ApiService.GetAsync<List<CategoriesModel.Get>>("categories");
                var activeCategories = categories.Where(c => c.inUse == 1).ToList();
                cbCategory.DataSource = activeCategories;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
