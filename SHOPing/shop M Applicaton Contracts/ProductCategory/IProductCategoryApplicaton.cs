using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_M_Applicaton_Contracts.ProductCategory
{
    public interface IProductCategoryApplicaton
    {
        void Create(CreateProductCategoty command);
        void Edit(EditProductCategory command);
       M_Domin.ProductCatgoryAgg. ProductCategory GetDetails(long id);
    }
}
