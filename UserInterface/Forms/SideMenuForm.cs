using System;
using System.Windows.Forms;
using UserInterface.RegisterSystemForms;

namespace UserInterface
{
    public partial class SideMenuForm : Form
    {

        private readonly FormsHandler formsHandler = new FormsHandler();
        public SideMenuForm()
        {
            InitializeComponent();
        }

        private void SideMenuForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.UserLogedIn)
            {
                usernameGrt.Text = login.UserName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formsHandler.LoadUserForm();
        }

        private void users_show_btn_Click(object sender, EventArgs e)
        {
            formsHandler.LoadDashboard();
            Forms.DashboardForm.UpdateDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
