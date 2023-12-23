using _0_Frimwork.Domin;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductPicturAgg
{
    public interface IProductPicturRpostory:IRepository<long,ProductPictur>
    {
        
        EditProductPictur GetDetails(long id);
        List<ProductPicturViewModel> SearCh(ProductPicturSearChModel searChModel);

    }
}
