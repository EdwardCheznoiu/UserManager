using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.RegisterSystemForms;

namespace UserInterface
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public void UpdateDashboard()
        {
            SqlUtilities sqlUtilities = new SqlUtilities();

            totalUsersNumber.Text = sqlUtilities.GetUsersNumber().ToString();
            totalBaseUsrNumber.Text = sqlUtilities.GetAdminsNumber().ToString();
            totalAdminsNumber.Text = sqlUtilities.GetBaseUsrNumber().ToString();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
