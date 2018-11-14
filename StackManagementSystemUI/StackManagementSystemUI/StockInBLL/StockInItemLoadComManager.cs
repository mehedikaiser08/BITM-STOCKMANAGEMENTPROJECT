using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StockInDAL;

namespace StackManagementSystemUI.StockInBLL
{
    public class StockInItemLoadComManager
    {
        public DataTable GetItemForComboBox(string selectedCategory)
        {
            StockInItemLoadComRipository sInItemLdComRipoObj = new StockInItemLoadComRipository();
            DataTable dt = sInItemLdComRipoObj.GetItemForComboBox(selectedCategory);
            return dt;
        }
    }
}
