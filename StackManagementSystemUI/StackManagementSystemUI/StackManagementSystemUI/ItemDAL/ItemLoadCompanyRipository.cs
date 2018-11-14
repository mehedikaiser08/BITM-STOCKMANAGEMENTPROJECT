using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StackManagementSystemUI.ItemDAL
{
    public class ItemLoadCompanyRipository
    {
        public DataTable ItemLoadCompanyComboBox()
        {
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Companies";
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
