using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StackManagementSystemUI.StockInDAL
{
    public class StockInSelectedItemRipository
    {
        public DataTable GetReorderAndAvaQuantity(string seletedItem)
        {
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT ReorderLabel,AvailableQuantity FROM Items WHERE Item='" + seletedItem + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(comd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
