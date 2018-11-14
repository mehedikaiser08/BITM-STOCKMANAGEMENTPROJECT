using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.StcOutDAL;

namespace StackManagementSystemUI.StcOutBLL
{
    public class StockOutItemManager
    {
        public DataTable GetItemForComboBox(string selectedCategory)
        {
            StockOutItemRipository sOutItemRipoObj = new StockOutItemRipository();
            DataTable dt = sOutItemRipoObj.GetItemForComboBox(selectedCategory);
            return dt;
        }
    }
}
