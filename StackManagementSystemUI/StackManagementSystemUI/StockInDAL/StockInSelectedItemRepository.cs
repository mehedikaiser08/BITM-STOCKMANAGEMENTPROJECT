using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.StockInDAL
{
    public class StockInSelectedItemRepository
    {
        public DataTable GetReorderLevel_and_AvailableQuantity(string seletedItem)
        {
            string connectionString = @"Server=USER;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT ReorderLabel,AvailableQuantity FROM Items WHERE Item='" + seletedItem + "'";
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
