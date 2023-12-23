using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.ProductCategoryQure
{
    public interface IProductCategoryQure
    {
        List<ProductCategoryQureModel> GetProductCategories();
    }
}
