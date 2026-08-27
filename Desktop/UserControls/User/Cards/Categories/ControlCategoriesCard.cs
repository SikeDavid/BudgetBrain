using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetBrainDesktop.UserControls.User.Cards.Categories
{
    public partial class ControlCategoriesCard : UserControl
    {
        public ControlCategoriesCard(CategoriesModel category)
        {
            InitializeComponent();

            lblName.Text = category.Name;
            lblType.Text = category.Type;
            btnSave.Text = "";
            btnSave.Image = Resources.save_icon;
            btnDelete.Text = "";
            btnDelete.Image = Resources.delete_icon;

        }
    }
}
