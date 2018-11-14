using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ViewDAL;
using StackManagementSystemUI.ViewModels;

namespace StackManagementSystemUI.ViewBLL
{
    public class ViewSellsManager
    {
        public DataTable ViewInfo(ViewInfo viewObj)
        {
            ViewSellsRipository viewRipoObj = new ViewSellsRipository();
            DataTable dt= viewRipoObj.ViewInfo(viewObj);
            return dt;
        }
    }
}
