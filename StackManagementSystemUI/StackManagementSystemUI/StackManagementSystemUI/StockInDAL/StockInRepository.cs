using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInModels;
using System.Data.SqlClient;

namespace StackManagementSystemUI.StockInDAL
{
    public class StockInRepository
    {
        public string StockInQuantity(StockIn stockInObj)
        {
            string stockInInfo = "";
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"UPDATE Items SET AvailableQuantity=" + (stockInObj.previousQuntity + stockInObj.stockInQuantity) + "WHERE Item='" + stockInObj.ItemName + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            int rowAffected = comd.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                stockInInfo = "Stock In Successfully !";
            }
            conn.Close();
            return stockInInfo;
        }
    }
}
