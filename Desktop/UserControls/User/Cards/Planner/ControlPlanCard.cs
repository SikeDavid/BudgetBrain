using BudgetBrainDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards.Planner
{
    public partial class ControlPlanCard : UserControl
    {
        public ControlPlanCard(PlannerModel plan)
        {
            InitializeComponent();

            lblDescription.Text = plan.Description;
            lblAmount.Text = plan.Amount.ToString();
            lblDayofMonth.Text = plan.DayofMonth.ToString();
            lblType.Text = plan.Type;
            if (plan.Type == "income")
            {
                lblType.ForeColor = Color.FromArgb(36, 182, 110);
            }
            else
            {
                lblType.ForeColor = Color.FromArgb(244, 79, 80);
            }
            if (plan.Active)
            {
                lblStatus.Text = "active";
                lblStatus.ForeColor = Color.FromArgb(36, 182, 110);
            }
            else
            {
                lblStatus.Text = "inactive";
                lblStatus.ForeColor = Color.FromArgb(244, 79, 80);
            }
            btnModify.Text = "";
            btnModify.Image = Properties.Resources.modify_icon;
            btnModify.ImageAlign = ContentAlignment.MiddleCenter;
            btnModify.FlatAppearance.BorderSize = 0;

            btnDelete.Text = "";
            btnDelete.Image = Properties.Resources.delete_icon;
            btnDelete.ImageAlign = ContentAlignment.MiddleCenter;
            btnModify.FlatAppearance.BorderSize = 0;
        }
    }
}
