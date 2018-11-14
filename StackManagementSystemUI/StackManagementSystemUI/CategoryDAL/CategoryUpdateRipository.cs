using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StackManagementSystemUI.CategoryModels;


namespace StackManagementSystemUI.CategoryDAL
{
    public class CategoryUpdateRipository
    {
        public bool CategoryUpdateName(CategoryUpdate updateCatgObj)
        {

            string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";
            string query = @"SELECT Name FROM Categories WHERE Name='" + updateCatgObj.CategoryUpdateName + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return false;
            }
            

            dr.Close();
            query = @"UPDATE Categories SET Name='" + updateCatgObj.CategoryUpdateName + "'WHERE Name='" + updateCatgObj.CategoryPreviousName +"'";
            comd = new SqlCommand(query, conn);
            comd.ExecuteNonQuery();
            conn.Close();

            return true;
        }
    }
}
