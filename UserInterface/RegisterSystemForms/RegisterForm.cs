using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class RegisterForm : Form
    {
        private readonly FormsHandler formshandler = new FormsHandler();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelRegisterUserBtn_Click(object sender, EventArgs e)
        {
            formshandler.LoadUserForm();
        }
    }
}
