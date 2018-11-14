using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.LoginModels;
using System.Data.SqlClient;

namespace StackManagementSystemUI.LoginDAL
{
    public class AccessRipository
    {
        public bool AccessInfo(Access accessObj)
        {

            bool login = false;

            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT UserName,Password FROM Logins WHERE UserName='" + accessObj.UserName +
                           "' AND Password='" + accessObj.Password + "'";

            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand comd=new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                login = true;
            }
            dr.Close();
            dr.Close();
            return login;
        }
    }
}
