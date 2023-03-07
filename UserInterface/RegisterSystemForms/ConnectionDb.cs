using System;
using System.Data;
using System.Data.SqlClient;

namespace UserInterface.RegisterSystemForms
{
    internal class ConnectionDb
    {
        private string _connectionString = "Data Source=localhost;Initial Catalog = user_manager; Integrated Security = True";
        private SqlConnection sqlCon;

        protected SqlDataAdapter sda;
        protected DataTable dt;
        protected SqlCommand cmd; 

        protected void OpenConnection()
        {
            sqlCon = new SqlConnection(_connectionString);
            sqlCon.Open();
        }

        protected void CloseConnection()
        {
            sqlCon.Close();
        }

        protected void ExecuteCommand(String query)
        {
            cmd = new SqlCommand(query, sqlCon);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
        }
    }
}
