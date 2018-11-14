using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI;
using StackManagementSystemUI.StcOutDAL;

namespace StackManagementSystemUI.StcOutBLL
{
    public class StockOutSelectedItemManager
    {
        public DataTable GetReorderAndAvaQuantity(string seletedItem)
        {
            StockOutSelectedItemRipository sOutSelectItemRipoObj = new StockOutSelectedItemRipository();
            DataTable dt = sOutSelectItemRipoObj.GetReorderAndAvaQuantity(seletedItem);
            return dt;
        }
    }
}
