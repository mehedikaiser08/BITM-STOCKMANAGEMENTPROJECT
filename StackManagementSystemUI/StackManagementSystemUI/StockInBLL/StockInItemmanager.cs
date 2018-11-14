using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;
using System.Data;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInItemManager
    {
        StockInItemRepository itemRepository = new StockInItemRepository();
        public DataTable GetItems(string selectedCategory)
        {

            DataTable dt = itemRepository.GetItems(selectedCategory);
            return dt;
        }
    }
}
