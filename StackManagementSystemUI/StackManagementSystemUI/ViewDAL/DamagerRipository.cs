﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StackManagementSystemUI.ViewModels;

namespace StackManagementSystemUI.ViewDAL
{
    public class DamagerRipository
    {
        public DataTable DamageInfo(ViewInfo viewObj)
        {
            string connectionString =
                @"Server=.\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";

            string query = "SELECT Item,Quantity FROM Stockouts WHERE Id=" + 2 + " AND (Date BETWEEN '" + viewObj.FromDate + "' AND '" + viewObj.ToDate + "')";
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
