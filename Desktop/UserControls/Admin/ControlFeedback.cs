using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.Admin.Cards;
using BudgetBrainDesktop.UserControls.Cards;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls
{
    public partial class ControlFeedback : UserControl
    {
        private List<FeedbackModel> feedbacks = new();
        public string PageTitle { get; } = "Feedback";

        public ControlFeedback()
        {
            InitializeComponent();

            this.Load += ControlFeedback_Load;
            tbSearch.TextChanged += TbSearchTextChanged;
        }

        private void TbSearchTextChanged(object? sender, EventArgs e)
        {
            FilterUsers();
        }

        private async void ControlFeedback_Load(object? sender, EventArgs e)
        {
            await LoadFeedbackAsync();
        }

        private async Task LoadFeedbackAsync()
        {
            try
            {
                feedbacks = await ApiService.GetAsync<List<FeedbackModel>>("test/feedback");
                DisplayFeedbacks(feedbacks);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayFeedbacks(IEnumerable<FeedbackModel> feedbacksToDisplay)
        {
            panelContent.Controls.Clear();

            foreach (FeedbackModel feed in feedbacksToDisplay)
            {
                ControlFeedbackCard card = new (feed);
                panelContent.Controls.Add(card);
            }
        }

        private void FilterUsers()
        {
            string searchText = tbSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                DisplayFeedbacks(feedbacks);
                return;
            }

            List<FeedbackModel> filteredFeeds = feedbacks
                .Where(feedbacks =>
                    feedbacks.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    feedbacks.Message.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                ).ToList();

            DisplayFeedbacks(filteredFeeds);
        }
    }
}
