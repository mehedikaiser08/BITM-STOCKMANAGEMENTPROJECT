using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StackManagementSystemUI.ItemDAL
{
    public class ItemLoadCategoryRipository
    {
        public DataTable ItemLoadCategoryComboBox()
        {
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Categories";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            DataTable DT = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(comd);
            da.Fill(DT);
            conn.Close();
            return DT;
        }
    }
}
