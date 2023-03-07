using System;
using System.Windows.Forms;
using UserInterface.RegisterSystemForms;

namespace UserInterface
{
    public partial class LoginForm : Form
    {
        private FormsHandler formsHandler = new FormsHandler();
        public LoginForm()
        {
            InitializeComponent();
        }

        public void LoginUserBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.TryLogIn(Forms.LoginForm.GetEmail().Text, Forms.LoginForm.GetPwd().Text);
            if (login.UserLogedIn)
            {
                formsHandler.LoadMain();
            }
        }

        public void RegisterFormBtn_Click(object sender, EventArgs e)
        {
            formsHandler.LoadRegisterForm();
        }
    }
}
