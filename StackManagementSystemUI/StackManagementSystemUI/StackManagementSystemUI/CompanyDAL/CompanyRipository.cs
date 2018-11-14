using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CompanyModels;
using System.Data.SqlClient;
using System.Data;

namespace StackManagementSystemUI.CompanyDAL
{
    public class CompanyRipository
    {
        public bool SaveCompInfo(Company comObj)
        {
            bool companyInfo = false;
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Companies WHERE Name='" + comObj.CompanyName + "'";
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
            else
            {
                dr.Close();
                conn.Close();
                query = @"INSERT INTO Companies(Name)Values('" + comObj.CompanyName + "')";
                comd = new SqlCommand(query, conn);
                conn.Open();
                comd.ExecuteNonQuery();
                conn.Close();
                companyInfo = true;
            }

            return companyInfo;
        }


        public DataTable CompanyDataTable()
        {

            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT *FROM Companies";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            DataTable DT = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comd);
            da.Fill(DT);
            conn.Close();
            return DT;
        }
    }
}
