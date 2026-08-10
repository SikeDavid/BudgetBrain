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
        public string PageTitle { get; } = "Feedback";
        public ControlFeedback()
        {
            InitializeComponent();
        }
    }
}
