using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.Artical
{
    public interface IArticalQurycs
    {
        ArticalQuryModel GetArticalDeitailes(string slug);
        List<ArticalQuryModel> LatesArticals();
    }
}
