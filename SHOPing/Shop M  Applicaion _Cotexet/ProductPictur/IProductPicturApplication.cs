using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.ProductPictur
{
    public interface IProductPicturApplication
    {
        OpratinResult Edit(EditProductPictur command);
        OpratinResult Creat(CreatProductPictur command) ;
        OpratinResult Remove(long Id);
        OpratinResult Restor(long Id);
        EditProductPictur GetDetails(long Id);
        List<ProductPicturViewModel> SearCh(ProductPicturSearChModel searChModel);
    }
}
