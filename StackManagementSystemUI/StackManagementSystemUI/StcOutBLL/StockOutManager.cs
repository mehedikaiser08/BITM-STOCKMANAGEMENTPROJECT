using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StcOutModels;
using StackManagementSystemUI.StcOutDAL;

namespace StackManagementSystemUI.StcOutBLL
{
    public class StockOutManager
    {
        public string StockOutInfo(StockOut stockOutObj)
        {
            string stockOutInfo = "";
            if (stockOutObj.Item==""||stockOutObj.Category==""||stockOutObj.Company==""||stockOutObj.StockOutQuantity==0)
            {
                stockOutInfo="Item,Category & Company should not be null";
            }

            if (stockOutObj.StockOutQuantity == 0)
            {
                stockOutInfo = "Please select amount to stockout";
            }

            if (stockOutObj.StockOutQuantity>stockOutObj.AvailableQuantity)
            {
                stockOutInfo ="There is no sufficient amount. You stock out maximum : " + stockOutObj.AvailableQuantity;
            }

  
            return stockOutInfo;


        }

        
    }
}
