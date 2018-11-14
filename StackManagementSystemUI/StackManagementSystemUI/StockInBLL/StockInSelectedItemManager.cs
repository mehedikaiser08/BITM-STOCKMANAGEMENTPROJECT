using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInSelectedItemManager
    {
        StockInSelectedItemRepository selectedItemRepository = new StockInSelectedItemRepository();
        public DataTable GetReorderLevel_and_AvailableQuantity(string seletedItem)
        {
           
            DataTable dt = selectedItemRepository.GetReorderLevel_and_AvailableQuantity(seletedItem);
            return dt;
        }
    }
}
