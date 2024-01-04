using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.Product
{
    public interface IProductQure 
    {
        ProductQureModel GetDitails(string slug);
        List<ProductQureModel> GetLatesArrivals();
        List<ProductQureModel> SearCh(string Value);
    }
}
