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
    public class ViewManager
    {
        public DataTable ViewInfo(ViewInfo viewObj)
        {
            ViewRipository viewRipoObj = new ViewRipository();
            DataTable dt= viewRipoObj.ViewInfo(viewObj);
            return dt;
        }
    }
}
