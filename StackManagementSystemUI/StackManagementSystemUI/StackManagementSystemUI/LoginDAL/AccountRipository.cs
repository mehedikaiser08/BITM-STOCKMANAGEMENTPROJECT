using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.LoginModels;
using System.Data.SqlClient;

namespace StackManagementSystemUI.LoginDAL
{
    public class AccountRipository
    {
        public bool AccountInfo(Account accounObj)
        {
            bool accountInfo = false;

            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT UserName,Password FROM Logins WHERE UserName='" + accounObj.Name +
                           "' AND Password='" + accounObj.Password + "'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return false;
            }
            dr.Close();
            dr.Close();


            query = @"INSERT INTO Logins(Name,Email,UserName,Password)VALUES('"+accounObj.Name+"','"+accounObj.Email+"','"+accounObj.UserName+"','"+accounObj.Password+"')";
            conn=new SqlConnection(connectionString);
            comd = new SqlCommand(query,conn);
            conn.Open();
            int rowAffected = comd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
            {
                accountInfo = true;
            }
            return accountInfo;
        }
    }
}
