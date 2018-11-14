using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CompanyModels;
using System.Data.SqlClient;

namespace StackManagementSystemUI.CompanyDAL
{
    public class CompanyUpdateRipository
    {
        public bool UpdateCompanyName(UpdateComName upComObj)
        {
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Companies WHERE Name='" + upComObj.CompanyUpdateName + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return false;
            }


            dr.Close();

            query = @"UPDATE Companies SET Name='" + upComObj.CompanyUpdateName + "'WHERE Name='" + upComObj.ComPreviousName + "'";
            comd = new SqlCommand(query, conn);
            comd.ExecuteNonQuery();
            conn.Close();

            return true;
        }
    }
}
