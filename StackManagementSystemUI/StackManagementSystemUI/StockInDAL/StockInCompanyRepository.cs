using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StackManagementSystemUI.StockInDAL
{
   public class StockInCompanyRepository
    {
           public DataTable GetCompanyNames()
           {
               string connectionString = @"Server=.\SQLExpress;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
               string query = @"SELECT Name FROM Companies";
               SqlConnection conn = new SqlConnection(connectionString);
               SqlCommand comdand = new SqlCommand(query, conn);
               DataTable dt = new DataTable();
               conn.Open();
               SqlDataAdapter da = new SqlDataAdapter(comdand);
               da.Fill(dt);
               conn.Close();
               return dt;
           }
       
    }
}
