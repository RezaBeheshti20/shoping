using _0_Frimwork.Application;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Product
{
    public interface IProductApplication
    {
        OpratinResult Creat(CreatProduct command);
        OpratinResult Edit(EditProduct command);
        OpratinResult IsStock(long Id);
        OpratinResult NotInStock(long Id);
        EditProduct Getdtails(long Id);
        List<ProductViewModel> GetProducts();
        List<ProductViewModel> SearCh(ProductSearChModel searChModel);
      
    }
}
