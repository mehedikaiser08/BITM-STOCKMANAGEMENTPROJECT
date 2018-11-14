using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StcOutModels;
using StackManagementSystemUI.StcOutDAL;


namespace StackManagementSystemUI.StcOutBLL
{
    public class StockOutSellManager
    {
        public bool SellItem(StockOutItem stcOutItmObj)
        {
            StockOutSellRipository sellRipoObj=new StockOutSellRipository();
            bool sellInfo = sellRipoObj.SellItem(stcOutItmObj);
            return sellInfo;
        }
    }
}
