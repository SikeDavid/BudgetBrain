using BudgetBrainDesktop.Models;
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

        private DateTime currentDate = DateTime.Today;
        public ControlUserEntries()
        {
            InitializeComponent();

            this.Load += ControlUserEntriesLoad;
            btnNextMonth.Click += BtnnextmonthClick;
            btnPrevMonth.Click += BtnprevmonthClick;

            btnAdd.Click += BtnaddClick;
        }

        private void BtnaddClick(object? sender, EventArgs e)
        {
            ControlAddEntryCard addControl = new();
            addControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(addControl);
            addControl.BringToFront();
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
                //MessageBox.Show(ex.Message);
                panelContent.Controls.Clear();
            }
        }

        private void DisplayEntry(IEnumerable<EntriesModel> entriesToDisplay)
        {
            panelContentEntries.Controls.Clear();

            foreach (EntriesModel entry in entriesToDisplay)
            {
                ControlEntriesEntryCard card = new (entry);

                card.Dock = DockStyle.None;
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                card.Margin = new Padding(5);
                panelContentEntries.Controls.Add(card);
            }
        }
    }
}
