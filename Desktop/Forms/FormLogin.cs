using BudgetBrainDesktop.Forms;
using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Services;
using BudgetBrainDesktop.UserControls.User.Cards.LoginReg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetBrainDesktop
{
    public partial class FormLogin : Form
    {
        private bool showLogin = true;
        public FormLogin()
        {
            InitializeComponent();

            this.Load += FormLogin_Load;
            btnSwitch.Click += BtnSwitchClick;

        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();

            page.Dock = DockStyle.Fill;

            panelContent.Controls.Add(page);
        }
        private void BtnSwitchClick(object? sender, EventArgs e)
        {
            if (showLogin)
            {
                LoadPage(new ControlRegistrationCard());
                btnSwitch.Text = "Already have an account?";
            }
            else
            {
                LoadPage(new ControlLoginCard());
                btnSwitch.Text = "Dont have an account?";
            }
            showLogin = !showLogin;
        }

        private void FormLogin_Load(object? sender, EventArgs e)
        {
            LoadPage(new ControlLoginCard());
            btnSwitch.Text = "Dont have an account?";
            //ControlLoginCard login = new();
            //panelContent.Controls.Add(login);
            ////btnSwitch.Text = "Dont have an account?";

            //ControlRegistrationCard registration = new();
            //panelContent.Controls.Add(registration);
            //btnSwitch.Text = "Already have an account?";
        }
    }
}
