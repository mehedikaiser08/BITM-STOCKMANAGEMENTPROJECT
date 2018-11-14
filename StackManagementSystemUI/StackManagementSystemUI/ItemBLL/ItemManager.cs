using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ItemDAL;
using StackManagementSystemUI.ItemModels;


namespace StackManagementSystemUI.ItemBLL
{
    public class ItemManager
    {
        public string SaveItemInfo(Item itemObj)
        {
            ItemRipository itemRipoObj = new ItemRipository();
            string itemInfo = itemRipoObj.SaveItemInfo(itemObj);
            return itemInfo;
        }
    }
}
