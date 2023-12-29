using _01_LampQuery.Conterctes.Product;
using _01_LampQuery.Conterctes.ProductCategoryQure;
 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiesHost.Pages
{
    public class  SearchModel: PageModel
    {
        public string Valu;
        public List<ProductQureModel> products;
        private readonly IProductQure _productQure;

        public SearchModel(IProductQure  productQure )
        {
            _productQure = productQure;
        }

        public void OnGet(string Value)
        {
            Valu = Value;
          products= _productQure.SearCh(Value);
        }
    }
}
