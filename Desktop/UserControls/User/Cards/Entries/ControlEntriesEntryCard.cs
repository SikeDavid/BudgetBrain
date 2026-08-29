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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BudgetBrainDesktop.UserControls.User.Cards
{
    public partial class ControlEntriesEntryCard : UserControl
    {
        private readonly int entryId;
        private bool paid;
        public ControlEntriesEntryCard(EntriesModel entry)
        {
            InitializeComponent();

            entryId = entry.Id;
            paid = Convert.ToBoolean(entry.Completed);

            lblDate.Text = entry.Date;
            lblType.Text = entry.Type;
            lblDescription.Text = entry.Description;
            lblCategory.Text = entry.Category;
            lblAmount.Text = entry.Amount.ToString();

            if (entry.Completed == 0)
            {
                lblAmount.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (entry.Amount < 0)
            {
                lblAmount.ForeColor = Color.FromArgb(244, 79, 80);
            }
            else if (entry.Amount >= 0)
            {
                lblAmount.Text = $"+{entry.Amount.ToString()}";
                lblAmount.ForeColor = Color.FromArgb(36, 182, 110);
            }

            if (entry.Type == "income")
            {
                lblType.ForeColor = Color.FromArgb(36, 182, 110);
            }
            else if (entry.Type == "expense")
            {
                lblType.ForeColor = Color.FromArgb(244, 79, 80);
            }

            btnPaid.Text = "";
            btnPaid.Image = paid ? Resources.check_icon : Resources.money_bag_icon;

            btnModify.Text = "";
            btnModify.Image = Resources.modify_icon;
            btnDelete.Text = "";
            btnDelete.Image = Resources.delete_icon;

            btnPaid.Click += BtnPaidClick;
        }

        public event EventHandler? EntryChanged;

        private async void BtnPaidClick(object? sender, EventArgs e)
        {
            btnPaid.Enabled = false;

            try
            {
                await ApiService.PatchAsync($"entries/{entryId}/complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modify failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPaid.Enabled = true;
                paid = !paid;
                btnPaid.Image = paid ? Resources.check_icon : Resources.money_bag_icon;
            }
        }
    }
}
