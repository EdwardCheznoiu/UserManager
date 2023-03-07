using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        private readonly FormsEventsHandler  formsEventsHandler = new FormsEventsHandler();
        private readonly FormsHandler formsHandler = new FormsHandler();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formsEventsHandler.InitEvents();
            formsHandler.LoadMain();
        }

        public void RegisterFormBtn_Click(object sender, EventArgs e)
        {
             
        }

        public void LoginFormBtn_Click(object sender, EventArgs e)
        {
             
        }

        public void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Forms.RegisterForm.GetFname().Text) || 
               String.IsNullOrEmpty(Forms.RegisterForm.GetLname().Text) || 
               String.IsNullOrEmpty(Forms.RegisterForm.GetEmail().Text) ||
               String.IsNullOrEmpty(Forms.RegisterForm.GetPwd().Text) ||
               String.IsNullOrEmpty(Forms.RegisterForm.GetAddress().Text))
            {
                Forms.RegisterForm.SetInfoArea("You must fill all the input areas!");
                return;
            }
            String databasecon = "Data Source=localhost;Initial Catalog = user_manager; Integrated Security = True";
            String query = "INSERT INTO users" +
                           "(user_fname, user_lname, user_email, user_pwd, user_address, user_access_level) " +
                           "VALUES(@user_fname, @user_lname, @user_email, @user_pwd, @user_address, @user_access_level);";

            SqlConnection con = new SqlConnection(databasecon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user_fname", Forms.RegisterForm.GetFname().Text);
            cmd.Parameters.AddWithValue("@user_lname", Forms.RegisterForm.GetLname().Text);
            cmd.Parameters.AddWithValue("@user_email", Forms.RegisterForm.GetEmail().Text);
            cmd.Parameters.AddWithValue("@user_pwd", Forms.RegisterForm.GetPwd().Text);
            cmd.Parameters.AddWithValue("@user_address", Forms.RegisterForm.GetAddress().Text);
            cmd.Parameters.AddWithValue("@user_access_level", 2);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            cmd.Dispose();
            con.Dispose();

            Forms.RegisterForm.SetInfoArea("Your account has been created!");
        }

        public void LoginUserBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Forms.LoginForm.GetEmail().Text) || String.IsNullOrEmpty(Forms.LoginForm.GetPwd().Text))
            {
                Forms.LoginForm.SetInfoArea("You must fill all the input areas!");
                return;
            }
            String databasecon = "Data Source=localhost;Initial Catalog = user_manager; Integrated Security = True";
            String query = "SELECT * FROM users WHERE user_email = '" + Forms.LoginForm.GetEmail().Text + "' AND user_pwd = '" + Forms.LoginForm.GetPwd().Text + "'" + "AND user_access_level = '1'";   
            SqlConnection con = new SqlConnection(databasecon);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count > 0)
            {
                Forms.MainForm.rightPanelMain.Controls.Remove(Forms.LoginForm);
                String query2 = "SELECT * FROM users where user_access_level = '2'";
                cmd = new SqlCommand(query2, con);
                sda = new SqlDataAdapter(cmd);
                DataTable tableUsers = new DataTable();
                sda.Fill(tableUsers);
                RightPanelMain.Visible = true;
                for (int i = 0; i < tableUsers.Rows.Count; i++)
                {
                     
                }  
            }
            else
            {
                Forms.LoginForm.SetInfoArea("Wrong user email or password");
            }
        }

    }
}
