using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI;
using StackManagementSystemUI.StockInDAL;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInSelectedItemManager
    {
        public DataTable GetReorderAndAvaQuantity(string seletedItem)
        {
            StockInSelectedItemRipository sInSelectItemRipoObj = new StockInSelectedItemRipository();
            DataTable dt=sInSelectItemRipoObj.GetReorderAndAvaQuantity(seletedItem);
            return dt;
        }
    }
}
