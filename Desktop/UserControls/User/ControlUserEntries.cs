using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.Cards;
using BudgetBrainDesktop.UserControls.User.Cards;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User
{
    public partial class ControlUserEntries : UserControl
    {
        public string PageTitle { get; } = "Entries";
        private List<EntriesModel> entries = new();
        private List<CategoriesModel> categories = new();

        private DateTime currentDate = DateTime.Today;
        private ControlAddEntryCard? addControl;
        public ControlUserEntries()
        {
            InitializeComponent();

            btnAdd.Text = "";
            btnAdd.Image = Resources.add_icon;

            this.Load += ControlUserEntriesLoad;
            btnNextMonth.Click += BtnnextmonthClick;
            btnPrevMonth.Click += BtnprevmonthClick;

            btnAdd.Click += BtnaddClick;
        }

        private void BtnaddClick(object? sender, EventArgs e)
        {
            if (addControl == null)
            {
                btnAdd.Image = Resources.close_icon;
                btnAdd.BackColor = Color.FromArgb(244, 79, 80);
                lblMonth.Visible = false;
                lblCategory.Visible = false;
                lblSearch.Visible = false;
                tlpMonthSelect.Visible = false;
                cbCategorySort.Visible = false;
                tbSearch.Visible = false;

                addControl = new(categories);
                addControl.Dock = DockStyle.Fill;
                addControl.EntryChanged += CardEntryChanged;
                panelContent.Controls.Add(addControl);
                addControl.BringToFront();
            }
            else
            {
                btnAdd.Image = Resources.add_icon;
                btnAdd.BackColor = Color.FromArgb(36, 182, 110);
                lblMonth.Visible = true;
                lblCategory.Visible = true;
                lblSearch.Visible = true;
                tlpMonthSelect.Visible = true;
                cbCategorySort.Visible = true;
                tbSearch.Visible = true;

                panelContent.Controls.Remove(addControl);
                addControl.Dispose();
                addControl = null;
            }

        }

        private async void BtnprevmonthClick(object? sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            lblCurrentMonth.Text = currentDate.ToString("yyyy. MMMM");
            await LoadEntriesAsync();
        }

        private async void BtnnextmonthClick(object? sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            lblCurrentMonth.Text = currentDate.ToString("yyyy. MMMM");
            await LoadEntriesAsync();
        }

        private async void ControlUserEntriesLoad(object? sender, EventArgs e)
        {
            lblCurrentMonth.Text = currentDate.ToString("yyyy. MMMM");
            await LoadCategoriesAsync();
            await LoadEntriesAsync();
        }

        private async Task LoadEntriesAsync()
        {
            try
            {
                entries = await ApiService.GetAsync<List<EntriesModel>>(
                    $"entries/?year={currentDate.ToString("yyyy")}&month={currentDate.ToString("MM")}");

                DisplayEntry(entries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                panelContent.Controls.Clear();
            }
        }

        private void DisplayEntry(IEnumerable<EntriesModel> entriesToDisplay)
        {
            panelContentEntries.Controls.Clear();

            foreach (EntriesModel entry in entriesToDisplay)
            {
                ControlEntriesEntryCard card = new (entry, categories);
                card.Dock = DockStyle.None;
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                card.Margin = new Padding(5);
                card.EntryChanged += CardEntryChanged;
                panelContentEntries.Controls.Add(card);
            }
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

        private async void CardEntryChanged(object? sender, EventArgs e)
        {
            await LoadEntriesAsync();
        }
    }
}
