using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User
{
    public partial class ControlUserFeedback : UserControl
    {
        public string PageTitle { get; } = "Feedback";
        public ControlUserFeedback()
        {
            InitializeComponent();
        }
    }
}
