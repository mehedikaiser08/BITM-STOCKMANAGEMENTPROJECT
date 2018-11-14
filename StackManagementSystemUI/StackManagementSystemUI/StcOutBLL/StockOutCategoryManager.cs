using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StcOutDAL;
using StackManagementSystemUI;

namespace StackManagementSystemUI.StcOutBLL
{
    public class StockOutCategoryManager
    {
        public DataTable GetCategoryNames(string selectedCompany)
        {
            StockOutCategoryRipository sOutCatgRipoObj = new StockOutCategoryRipository();
            DataTable dt = sOutCatgRipoObj.GetCategoryNames(selectedCompany);
            return dt;
        }
    }
}
