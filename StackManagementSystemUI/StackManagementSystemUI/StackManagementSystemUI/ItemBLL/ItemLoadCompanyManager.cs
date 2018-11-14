using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ItemDAL;

namespace StackManagementSystemUI.ItemBLL
{
    public class ItemLoadCompanyManager
    {
        public DataTable ItemLoadCompanyComboBox()
        {
            ItemLoadCompanyRipository itemLdCompRipoObj=new ItemLoadCompanyRipository();
            DataTable DT = itemLdCompRipoObj.ItemLoadCompanyComboBox();
            return DT;

        }
    }
}
