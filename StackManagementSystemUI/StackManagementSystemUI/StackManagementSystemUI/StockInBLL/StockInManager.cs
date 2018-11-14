using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInModels;
using StackManagementSystemUI.StockInDAL;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInManager
    {
        public string StockInQuantity(StockIn stockInObj)
        {
            StockInRepository stockInRepoObj = new StockInRepository();
            string stockInInfo = stockInRepoObj.StockInQuantity(stockInObj);
            return stockInInfo;
        }
    }
}
