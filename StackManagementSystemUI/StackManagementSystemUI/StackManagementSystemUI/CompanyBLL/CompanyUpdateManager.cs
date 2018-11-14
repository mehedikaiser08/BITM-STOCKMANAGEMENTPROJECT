using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CompanyDAL;
using StackManagementSystemUI.CompanyModels;

namespace StackManagementSystemUI.CompanyBLL
{
    public class CompanyUpdateManager
    {
        public bool UpdateCompanyName(UpdateComName upComObj)
        {
            CompanyUpdateRipository comUpRipoObj = new CompanyUpdateRipository();
            bool updateInfo = comUpRipoObj.UpdateCompanyName(upComObj);
            return updateInfo;
        }
    }
}
