using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.SearchModels;
using System.Data;
using System.Data.SqlClient;

namespace StackManagementSystemUI.SearchDAL
{
    public class SearchRipository
    {
        public DataTable SearchInfo(Search searchObj)
        {
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";

            string query = "SELECT Item,Category,Company,AvailableQuantity,ReorderLabel FROM Items WHERE Category='"+ searchObj.Category +"' AND Company='"+searchObj.Company +"'";
            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand comd=new SqlCommand(query,conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(comd);
            da.Fill(dt);
            conn.Close();
            
            return dt;
        }
    }
}
