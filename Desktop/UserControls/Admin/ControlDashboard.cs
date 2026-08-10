using BudgetBrainDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls
{
    public partial class ControlDashboard : UserControl
    {
        public string PageTitle { get; } = "Dashboard";
        public ControlDashboard()
        {
            InitializeComponent();
            this.Load += ControlDashboardLoad;
        }

        private void ControlDashboardLoad(object? sender, EventArgs e)
        {
            lbaccess.Text = TokenStorage.AccessToken;
            lbrefresh.Text = TokenStorage.RefreshToken;
        }
    }
}
