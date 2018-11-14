using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ItemDAL;

namespace StackManagementSystemUI.ItemBLL
{
    public class ItemLoadCategoryManager
    {
        public DataTable ItemLoadCategoryComboBox()
        {
            ItemLoadCategoryRipository itemLdCatgRipoObj = new ItemLoadCategoryRipository();
            DataTable DT = itemLdCatgRipoObj.ItemLoadCategoryComboBox();
            return DT;
        }
    }
}
