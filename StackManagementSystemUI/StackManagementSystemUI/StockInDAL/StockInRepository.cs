using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInModels;

namespace StackManagementSystemUI.StockInDAL
{
   public class StockInRepository
    {
       public string StockInQuantity(StockIn stockInObj)
       {
           string stockInInfo = "";
           string connectionString = @"Server=.\SQLExpress;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
           string query = @"UPDATE Items SET AvailableQuantity=" + (stockInObj.previousQuantity + stockInObj.stockInQuantity) + "WHERE Item='" + stockInObj.ItemName + "'";
           SqlConnection conn = new SqlConnection(connectionString);
           SqlCommand comand = new SqlCommand(query, conn);
           conn.Open();
           int rowAffected = comand.ExecuteNonQuery();
           if (rowAffected > 0)
           {
               stockInInfo = "Stock In Successfully !";
           }
           conn.Close();
           return stockInInfo;
       }
    }
}
