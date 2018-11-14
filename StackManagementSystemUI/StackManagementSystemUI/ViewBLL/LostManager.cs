using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.ViewModels;
using StackManagementSystemUI.ViewDAL;

namespace StackManagementSystemUI.ViewBLL
{
    public class LostManager
    {
        public DataTable LostInfo(ViewInfo viewObj)
        {
            LostRipository lostRipoObj=new LostRipository();
            DataTable dt = lostRipoObj.LostInfo(viewObj);
            return dt;
        }
    }
}
