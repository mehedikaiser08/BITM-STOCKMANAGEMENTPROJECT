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
    public class StockOutCompanyManager
    {
        public DataTable GetCompanyNames()
        {
            StockOutCompanyRipository stockOutComRipObj = new StockOutCompanyRipository();
            DataTable dt = stockOutComRipObj.GetCompanyNames();
            return dt;
        }
    }
}
