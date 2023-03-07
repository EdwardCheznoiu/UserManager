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
    public partial class UserForm : Form
    {
        private SqlUtilities sqlUtilities = new SqlUtilities();
        public UserForm()
        {
            InitializeComponent();
        }

        private async void searchUserInput_TextChanged(object sender, EventArgs e)
        {
            if (searchUserInput.Focused)
            {
                sqlUtilities.FilterSearch(searchUserInput.Text);
            }
            else
            {
                sqlUtilities.FillUserGridView();
            }
            
        }

        private void searchUserInput_GainedFocus(object sender, EventArgs e)
        {
            searchUserInput.Text = "";  
        }

        private void searchUserInput_LostFocus(object sender, EventArgs e)
        {
            searchUserInput.Text = "Search user...";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserGridView.Columns[e.ColumnIndex].Name == "deleteUser")
            {
                string userId = UserGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                string message = "Do you want to delete this user?";
                string title = "Delete user";
                MessageBoxButtons msgButtons = MessageBoxButtons.YesNo;
                DialogResult dlResult = MessageBox.Show(message, title, msgButtons);
                if (dlResult == DialogResult.Yes)
                {
                    sqlUtilities.DeleteUser(userId);
                    sqlUtilities.FillUserGridView();
                }
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            sqlUtilities.FillUserGridView();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            FormsHandler formsHandler = new FormsHandler();
            formsHandler.LoadRegisterForm();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
