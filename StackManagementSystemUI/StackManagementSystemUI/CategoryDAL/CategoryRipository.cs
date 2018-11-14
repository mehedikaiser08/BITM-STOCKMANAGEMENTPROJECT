using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CategoryModels;
using System.Data.SqlClient;
using System.Data;

namespace StackManagementSystemUI.CategoryDAL
{
    public class CategoryRipository
    {
        public bool SaveCatgoryInfo(Category categoryObj)
        {
            bool categoryInfo = false;
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Categories WHERE Name='" + categoryObj.CategoryName + "'";
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
                query = @"INSERT INTO Categories(Name)Values('" + categoryObj.CategoryName + "')";
                comd = new SqlCommand(query, conn);
                conn.Open();
                comd.ExecuteNonQuery();
                conn.Close();
                categoryInfo = true;
            }

            return categoryInfo;
        }

        public DataTable CategoryDataTable()
        {

            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT *FROM Categories";
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
