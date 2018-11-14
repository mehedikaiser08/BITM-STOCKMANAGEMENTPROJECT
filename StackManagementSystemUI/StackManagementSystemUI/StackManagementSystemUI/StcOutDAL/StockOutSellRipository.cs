using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StcOutModels;
using System.Data.SqlClient;


namespace StackManagementSystemUI.StcOutDAL
{
    public class StockOutSellRipository
    {
        public bool SellItem(StockOutItem stcOutItmObj)
        {

            bool sellInfo = false;
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=STOCKMANAGEMENTSYSTEM;Integrated Security=true";

            string query = @"UPDATE Items SET AvailableQuantity=(AvailableQuantity-" + stcOutItmObj.StockOutQuantity +
                           ")WHERE Item='" + stcOutItmObj.Item + "' AND Company='" + stcOutItmObj.Company + "'";


            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand comd=new SqlCommand(query,conn);
            conn.Open();
            comd.ExecuteNonQuery();
            conn.Close();


            query = @"INSERT INTO Stockouts(Id,Item,Category,Company,Quantity,Date)VALUES(" + stcOutItmObj.Id + ",'" + stcOutItmObj.Item + "','" + stcOutItmObj.Category + "','" + stcOutItmObj.Company + "'," + stcOutItmObj.StockOutQuantity + ",'" + stcOutItmObj.SellDate+ "')";

            comd = new SqlCommand(query,conn);
            conn.Open();
            int rowAffected = comd.ExecuteNonQuery();
            conn.Close();

            if (rowAffected > 0)
            {
                sellInfo = true;
            }
            return sellInfo;
        }

       
    }
}
