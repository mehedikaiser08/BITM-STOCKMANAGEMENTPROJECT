using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StackManagementSystemUI.ViewModels;
using StackManagementSystemUI.ViewDAL;

namespace StackManagementSystemUI.ViewBLL
{
    public class DamageManager
    {
        public DataTable DamageInfo(ViewInfo viewObj)
        {
            DamagerRipository damgRipoObj = new DamagerRipository();
            DataTable dt = damgRipoObj.DamageInfo(viewObj);
            return dt;
        }
    }
}
