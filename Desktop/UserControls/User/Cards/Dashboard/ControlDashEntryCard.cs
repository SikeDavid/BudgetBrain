using BudgetBrainDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards
{
    public partial class ControlDashEntryCard : UserControl
    {
        public ControlDashEntryCard(EntriesModel entry)
        {
            InitializeComponent();

            lblDate.Text = entry.Date;
            lblDescription.Text = $"{entry.Category} - {entry.Description}";
            lblAmount.Text = entry.Amount.ToString();


            if (entry.Completed == 0)
            {
                lblAmount.ForeColor = Color.FromArgb(255, 255 ,255);
                //BackColor = Color.LightGray;
            }
            else if (entry.Amount < 0)
            {
                lblAmount.ForeColor = Color.FromArgb(244, 79, 80);
                //BackColor = Color.LightCoral;
            }
            else if (entry.Amount >= 0)
            {
                lblAmount.ForeColor = Color.FromArgb(36, 182, 110);
                //BackColor = Color.LightGreen;
            }
        }
    }
}
