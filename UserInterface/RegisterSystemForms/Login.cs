using System;
using System.Data;
using System.Data.SqlClient;

namespace UserInterface.RegisterSystemForms
{
    internal class Login : ConnectionDb
    {
        private static bool _userLogedIn = false; 
        private static string _username = "";
        private static int _userId;

        public bool UserLogedIn => _userLogedIn;
        public string UserName => _username;
        public int UserId => _userId;
        public void TryLogIn(string username, string passsword)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(passsword))
            {
                Forms.LoginForm.SetInfoArea("You must fill all the input areas!");
                return;
            }
            OpenConnection();
            String query = "SELECT * FROM users WHERE user_nickname = '" + username + "' AND user_pwd = '" + passsword + "'" + "AND user_access_level = '1'";
            ExecuteCommand(query);
            if (dt.Rows.Count > 0)
            {
                _userLogedIn = true;
                _username = username;
                _userId = (int) dt.Rows[0]["user_id"];
            }
            else
            {
                Forms.LoginForm.SetInfoArea("Wrong username or password!");
            }
            CloseConnection();
        }
    }
}
