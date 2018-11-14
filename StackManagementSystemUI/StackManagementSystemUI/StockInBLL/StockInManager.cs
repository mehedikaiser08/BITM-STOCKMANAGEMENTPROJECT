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
       StockInRepository stockInRepository = new StockInRepository();
       public string StockInQuantity(StockIn stockInObj)
       {
         
           string stockInInfo = stockInRepository.StockInQuantity(stockInObj);
           return stockInInfo;
       }

    }
}
