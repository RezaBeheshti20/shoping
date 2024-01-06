using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticalCategorii
{
    public interface IArticalCategoriyApplicationcs
    {
        OpratinResult Creat(CreatArticalCategoriy command) ;
        OpratinResult Edit(EditArticalCategoriy command);
        EditArticalCategoriy GetDitails(long id);
        List<ArticalCategoriyViewModel>Search(ArticalCategoriySearchModel searchModel) ;
    } 
}
