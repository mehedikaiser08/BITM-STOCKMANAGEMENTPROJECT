using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ItemModels;
using System.Data.SqlClient;

namespace StackManagementSystemUI.ItemDAL
{
    public class ItemRipository
    {
        public string SaveItemInfo(Item itemObj)
        {
            //string itemInfo = "";
            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Item FROM Items WHERE Item='" + itemObj.ItemName + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return "Same Item Exist !";
            }
            else
            {
                dr.Close();
                conn.Close();
                query = @"INSERT INTO Items(Item,Company,Category,AvailableQuantity,ReorderLabel)Values('" + itemObj.ItemName + "','" + itemObj.CompanyName + "','" + itemObj.Category + "'," + itemObj.AvaialableQuantity + "," + itemObj.ReorderLabel + ")";
                comd = new SqlCommand(query, conn);
                conn.Open();
                comd.ExecuteNonQuery();
                conn.Close();
            }

            return "Item Saved Successfully !";
        }

    }
}
