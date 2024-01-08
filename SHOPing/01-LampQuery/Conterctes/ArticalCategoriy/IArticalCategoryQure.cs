using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.ArticalCategoriy
{
    public interface IArticalCategoryQure
    {
        ArticalCategoriyQureModel GetArticalCategoriy(string slug);
        List<ArticalCategoriyQureModel> GetArticalCategoriys();
    }
}
