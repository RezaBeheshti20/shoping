using _0_Frimwork.Domin;
using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductAgg
{
    public interface IProductRepostori:IRepository<long,Product>
    {
        List<ProductViewModel> GetProducts();
        EditProduct GetDetails(long id);
        List<ProductViewModel> SearCh(ProductSearChModel searChModel);
    }
}
