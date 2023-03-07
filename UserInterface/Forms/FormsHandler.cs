using System;
using System.Windows.Forms;

namespace UserInterface
{
    internal class FormsHandler
    {
        public void LoadMain()
        {
            Forms.LoginForm.Hide();
            Forms.SideMenuForm.MdiParent = Forms.MainForm;
            Forms.DashboardForm.MdiParent = Forms.MainForm;
            Forms.UserForm.MdiParent = Forms.MainForm;
            Forms.RegisterForm.MdiParent = Forms.MainForm;  
            Forms.MainForm.LeftPanelMain.Controls.Add(Forms.SideMenuForm);
            Forms.MainForm.RightPanelMain.Controls.Add(Forms.DashboardForm);
            Forms.MainForm.Show();
            Forms.SideMenuForm.Show();
            Forms.DashboardForm.Show();
            //Forms.LoginForm.Dispose();
        }

        public void LoadDashboard()
        {
            Forms.MainForm.RightPanelMain.Controls.Clear();
            Forms.MainForm.RightPanelMain.Controls.Add(Forms.DashboardForm);
            Forms.DashboardForm.Show();
        }

        public void LoadUserForm()
        {
            Forms.MainForm.RightPanelMain.Controls.Clear();
            Forms.MainForm.RightPanelMain.Controls.Add(Forms.UserForm);
            Forms.UserForm.Show();
        }

        public void LoadLoginForm()
        {
             
        }

        public void LoadRegisterForm()
        {
            Forms.MainForm.RightPanelMain.Controls.Clear();
            Forms.MainForm.RightPanelMain.Controls.Add(Forms.RegisterForm);
            Forms.RegisterForm.Show();
        }
    }
}
