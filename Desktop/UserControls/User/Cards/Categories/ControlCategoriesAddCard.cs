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

namespace BudgetBrainDesktop.UserControls.User.Cards.Categories
{
    public partial class ControlCategoriesAddCard : UserControl
    {
        public ControlCategoriesAddCard()
        {
            InitializeComponent();

            cbType.Items.Add("income");
            cbType.Items.Add("expense");
            cbType.SelectedItem = "expense";

            btnSave.Text = "";
            btnSave.Image = Resources.save_icon;

            btnSave.Click += BtnSaveClick;
        }

        private async void BtnSaveClick(object? sender, EventArgs e)
        {
            CategoriesModel.Post body = new()
            {
                Name = tbDescription.Text,
                Type = cbType.SelectedItem.ToString(),
                InUse = 1
            };

            try
            {
                btnSave.Enabled = false;

                MessageModel response = await ApiService.PostAsync<CategoriesModel.Post, MessageModel>("categories", body);

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
                CategoriesChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler? CategoriesChanged;
    }
}
