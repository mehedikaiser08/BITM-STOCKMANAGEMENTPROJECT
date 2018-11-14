using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;
using StackManagementSystemUI;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInCategoryComboManager
    {
        public DataTable GetCategoryNames(string selectedCompany)
        {
            StockInCategoryComboBoxRipository sInCatgComboRipoObj = new StockInCategoryComboBoxRipository();
            DataTable dt = sInCatgComboRipoObj.GetCategoryNames(selectedCompany);
            return dt;
        }
    }
}
