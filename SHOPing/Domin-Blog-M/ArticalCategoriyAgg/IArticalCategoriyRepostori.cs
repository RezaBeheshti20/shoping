using _0_Frimwork.Domin;
using Blog_Application_Cotercts.ArticalCategorii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin_Blog_M.ArticalCategoriyAgg
{
    public interface IArticalCategoriyRepostori:IRepository<long,ArticalCatagoriy>
    {
        EditArticalCategoriy GetDitails(long id);
         string GetSlugBay(long id);
    List<ArticalCategoriyViewModel> Search(ArticalCategoriySearchModel searchModel);
    }
}
