using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using BudgetBrainDesktop.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.Admin.Cards
{
    public partial class ControlFeedbackCard : UserControl
    {
        private readonly FeedbackModel feedback;
        private bool readed;

        public ControlFeedbackCard(FeedbackModel feedback)
        {
            InitializeComponent();

            this.feedback = feedback;
            this.readed = Convert.ToBoolean(feedback.Readed);

            panelContent.Visible = false;
            Height = 100;

            btnExpand.Click += BtnExpand_Click;
            btnRead.Click += BtnReadClick;
            btnDelete.Click += BtnDeleteClick;

            btnExpand.Text = "";
            btnExpand.Image = Resources.arrow_downward_icon;

            lblId.Text = Convert.ToString(feedback.Id);
            lblTitle.Text = feedback.Title;
            if (feedback.Username is null)
            {
                lblUser.Text = feedback.Quest;
            }
            else
            {
                lblUser.Text = feedback.Username;
            }
            btnRead.Text = readed ? "readed" : "not readed";
            btnRead.Image = readed ? Resources.visibility_on_icon : Resources.visibility_off_icon;

            btnDelete.Text = "";
            btnDelete.Image = Resources.delete_icon;

            rtbMessage.Text = feedback.Message;
        }

        private async void BtnDeleteClick(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Deleting {lblTitle.Text} feedback?", "Deleting feedback",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                btnDelete.Enabled = false;

                await ApiService.DeleteAsync($"test/feedback/{feedback.Id}");

                Parent?.Controls.Remove(this);
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnDelete.Enabled = true;
                }

            }
        }

        private async void BtnReadClick(object? sender, EventArgs e)
        {
            try
            {
                btnRead.Enabled = false;

                await ApiService.PatchAsync($"test/feedback/{feedback.Id}");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRead.Enabled = true;
                readed = !readed;
                btnRead.Text = readed ? "readed" : "not readed";
                btnRead.Image = readed ? Resources.visibility_on_icon : Resources.visibility_off_icon;
            }
        }

        private void BtnExpand_Click(object? sender, EventArgs e)
        {
            panelContent.Visible = !panelContent.Visible;
            Height = panelContent.Visible ? 400 : 100;
            btnExpand.Text = "";
            btnExpand.Image = panelContent.Visible ? Resources.arrow_upward_icon : Resources.arrow_downward_icon;
        }
    }
}
