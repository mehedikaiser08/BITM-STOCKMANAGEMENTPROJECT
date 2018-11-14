using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackManagementSystemUI.CategoryDAL;
using StackManagementSystemUI.CategoryModels;
using System.Data;


namespace StackManagementSystemUI.CategoryBLL
{
    public class CategoryManager
    {
        CategoryRipository categoryRipoObj = new CategoryRipository();
        public bool SaveCatgoryInfo(Category categoryObj)
        {
            bool categoryInfo = categoryRipoObj.SaveCatgoryInfo(categoryObj);
            return categoryInfo;
        }

        public DataTable CategoryDataTable()
        {
            DataTable DT = categoryRipoObj.CategoryDataTable();
            return DT;
        }
    }
}
