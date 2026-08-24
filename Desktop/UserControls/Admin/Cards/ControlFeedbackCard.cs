using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
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
        //private readonly int Id;
        //private readonly string Title;
        //private readonly string Message;
        //private readonly string User;
        //private readonly string Quest;

        public ControlFeedbackCard(FeedbackModel feedback)
        {
            InitializeComponent();

            panelContent.Visible = false;
            Height = 100;

            btnExpand.Click += BtnExpand_Click;

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
            cbReaded.Checked = Convert.ToBoolean(feedback.Readed);
            rtbMessage.Text = feedback.Message;
        }

        private void BtnExpand_Click(object? sender, EventArgs e)
        {
            panelContent.Visible = !panelContent.Visible;
            Height = panelContent.Visible ? 400 : 100;
        }
    }
}
