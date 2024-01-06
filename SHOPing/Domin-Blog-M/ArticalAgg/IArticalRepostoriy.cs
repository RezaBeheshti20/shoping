using _0_Frimwork.Domin;
using Blog_Application_Cotercts.ArticaL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin_Blog_M.ArticalAgg
{
    public interface IArticalRepostoriy:IRepository<long,Artical>
    {
       
        EditArtical GetDeitails(long id);
        Artical GetWithCategory(long  id);
        List<ArticalViewModel> Search(ArticalSearchModel searchModel);
    }
}
