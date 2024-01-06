using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticaL
{
    public interface IArticalApplication
    {
        OpratinResult Edit(EditArtical command);
        OpratinResult Creat(CreatArtical command);
        EditArtical GetDeitails (long id);
        List<ArticalViewModel> Search(ArticalSearchModel searchModel);
    }
}
