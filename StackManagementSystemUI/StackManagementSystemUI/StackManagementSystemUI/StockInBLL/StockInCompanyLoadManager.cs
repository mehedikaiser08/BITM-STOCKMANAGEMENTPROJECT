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
    public class StockInCompanyLoadManager
    {
        public DataTable GetCompanyNames()
        {
            StockInCompanyLoadRipository stockInComLdRipObj=new StockInCompanyLoadRipository();
            DataTable dt = stockInComLdRipObj.GetCompanyNames();
            return dt;
        }
    }
}
