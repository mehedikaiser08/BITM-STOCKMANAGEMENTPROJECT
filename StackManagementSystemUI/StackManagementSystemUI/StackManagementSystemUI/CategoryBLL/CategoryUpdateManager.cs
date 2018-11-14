using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using StackManagementSystemUI.CategoryDAL;
using StackManagementSystemUI.CategoryModels;

namespace StackManagementSystemUI.CategoryBLL
{
    public class CategoryUpdateManager
    {
        public bool CategoryUpdateName(CategoryUpdate updateCatgObj)
        {
            CategoryUpdateRipository catgUpdRipoObj = new CategoryUpdateRipository();
            bool updateCatgInfo = catgUpdRipoObj.CategoryUpdateName(updateCatgObj);
            return updateCatgInfo;
        }
        
        
        
    }
}
