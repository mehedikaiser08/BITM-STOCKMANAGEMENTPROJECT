using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.SearchDAL;
using StackManagementSystemUI.SearchModels;

namespace StackManagementSystemUI.SearchBLL
{
    public class SearchManager
    {
        public DataTable SearchInfo(Search searchObj)
        {
            SearchRipository searchRipoObj = new SearchRipository();
            DataTable dt = searchRipoObj.SearchInfo(searchObj);
            return dt;
        }
    }
}
