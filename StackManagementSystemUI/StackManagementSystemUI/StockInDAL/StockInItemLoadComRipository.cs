﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StackManagementSystemUI.StockInDAL
{
    public class StockInItemLoadComRipository
    {
        public DataTable GetItemForComboBox(string selectedCategory)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Item FROM Items WHERE Category='" + selectedCategory + "'";
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
