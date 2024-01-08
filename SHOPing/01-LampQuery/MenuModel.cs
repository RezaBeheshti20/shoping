using _01_LampQuery.Conterctes.ArticalCategoriy;
using _01_LampQuery.Conterctes.ProductCategoryQure;
using _01_LampQuery.Qure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery
{
    public class MenuModel
    {
    
       public List<ArticalCategoriyQureModel> AArticalCategoriyQures { get; set; }
       public List<ProductCategoryQure> productCategoryQures { get; set; }
        public Func<List<ProductCategoryQureModel>> ProductCategoryQure { get; set; }
    }
}