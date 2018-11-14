using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.StockInDAL
{
    public class StockInItemRepository
    {
        public DataTable GetItems(string selectedCategory)
        {
            string connectionString = @"Server=.\SQLExpress;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Item FROM Items WHERE Category='" + selectedCategory + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comand = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(comand);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
