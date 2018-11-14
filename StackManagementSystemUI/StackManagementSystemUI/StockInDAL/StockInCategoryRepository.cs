using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackManagementSystemUI.StockInDAL
{
   public class StockInCategoryRepository
    {
       public DataTable GetCategoryNames(string selectedCompany)
       {
           string connectionString = @"Server=USER;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
           string query = @"SELECT DISTINCT Category FROM Items WHERE Company='" + selectedCompany + "'";
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
