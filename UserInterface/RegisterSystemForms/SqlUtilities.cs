using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.RegisterSystemForms
{
    internal class SqlUtilities : ConnectionDb
    {
        public void FillUserGridView()
        {
            OpenConnection();
            Login login = new Login();
            String query = "SELECT * FROM users WHERE user_id != " + login.UserId;
            ExecuteCommand(query);
            if (dt.Rows.Count > 0)
            {
                Forms.UserForm.UserGridView.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["user_access_level"].ToString() == "1")
                    {
                        Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                         dt.Rows[i]["user_fname"].ToString(),
                                                         dt.Rows[i]["user_lname"].ToString(),
                                                         dt.Rows[i]["user_email"].ToString(),
                                                         dt.Rows[i]["user_nickname"].ToString(),
                                                         dt.Rows[i]["user_pwd"].ToString(),
                                                         dt.Rows[i]["user_address"].ToString(),"Admin");
                    }
                    else
                    {
                        Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                         dt.Rows[i]["user_fname"].ToString(),
                                                         dt.Rows[i]["user_lname"].ToString(),
                                                         dt.Rows[i]["user_email"].ToString(),
                                                         dt.Rows[i]["user_nickname"].ToString(),
                                                         dt.Rows[i]["user_pwd"].ToString(),
                                                         dt.Rows[i]["user_address"].ToString(), "Basic User");
                    }
                    
                }
            }
            CloseConnection();
        }

        public void DeleteUser(string id)
        {
            OpenConnection();
            String query = "DELETE FROM users WHERE user_id = " + id;
            ExecuteCommand(query);
            CloseConnection();
        }

        public int GetUsersNumber()
        {
            OpenConnection();
            String query = "SELECT COUNT(*) FROM users";
            ExecuteCommand(query);
            CloseConnection();
            return (int) dt.Rows[0][0];
        }

        public int GetAdminsNumber()
        {
            OpenConnection();
            String query = "SELECT COUNT(*) FROM users WHERE user_access_level = '1'";
            ExecuteCommand(query);
            CloseConnection();
            return (int)dt.Rows[0][0];
        }

        public int GetBaseUsrNumber()
        {
            OpenConnection();
            String query = "SELECT COUNT(*) FROM users WHERE user_access_level = '2'";
            ExecuteCommand(query);
            CloseConnection();
            return (int)dt.Rows[0][0];
        }

        public void FilterSearch(string filter)
        {
            OpenConnection();
            Login login = new Login();
            if (string.IsNullOrEmpty(filter))
            {
                String query = "SELECT * FROM users WHERE user_id != " + login.UserId;
                ExecuteCommand(query);
                if (dt.Rows.Count > 0)
                {
                    Forms.UserForm.UserGridView.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["user_access_level"].ToString() == "1")
                        {
                            Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                             dt.Rows[i]["user_fname"].ToString(),
                                                             dt.Rows[i]["user_lname"].ToString(),
                                                             dt.Rows[i]["user_email"].ToString(),
                                                             dt.Rows[i]["user_nickname"].ToString(),
                                                             dt.Rows[i]["user_pwd"].ToString(),
                                                             dt.Rows[i]["user_address"].ToString(), "Admin");
                        }
                        else
                        {
                            Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                             dt.Rows[i]["user_fname"].ToString(),
                                                             dt.Rows[i]["user_lname"].ToString(),
                                                             dt.Rows[i]["user_email"].ToString(),
                                                             dt.Rows[i]["user_nickname"].ToString(),
                                                             dt.Rows[i]["user_pwd"].ToString(),
                                                             dt.Rows[i]["user_address"].ToString(), "Basic User");
                        }

                    }
                }
            }
            else
            {
                String query = "SELECT * FROM users WHERE (user_fname LIKE '" + filter + "%' OR user_lname LIKE '" + filter + "%') AND user_id != " + login.UserId;
                ExecuteCommand(query);

                Forms.UserForm.UserGridView.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["user_access_level"].ToString() == "1")
                    {
                        Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                            dt.Rows[i]["user_fname"].ToString(),
                                                            dt.Rows[i]["user_lname"].ToString(),
                                                            dt.Rows[i]["user_email"].ToString(),
                                                            dt.Rows[i]["user_nickname"].ToString(),
                                                            dt.Rows[i]["user_pwd"].ToString(),
                                                            dt.Rows[i]["user_address"].ToString(), "Admin");
                    }
                    else
                    {
                        Forms.UserForm.UserGridView.Rows.Add(dt.Rows[i]["user_id"].ToString(),
                                                            dt.Rows[i]["user_fname"].ToString(),
                                                            dt.Rows[i]["user_lname"].ToString(),
                                                            dt.Rows[i]["user_email"].ToString(),
                                                            dt.Rows[i]["user_nickname"].ToString(),
                                                            dt.Rows[i]["user_pwd"].ToString(),
                                                            dt.Rows[i]["user_address"].ToString(), "Basic User");
                    }

                }
                
            }
            CloseConnection();
        }
    }
}
