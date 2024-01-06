using _01_LampQuery.Conterctes.ProductCategoryQure;
 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SHop__m_Domin.ProductCategoryAgg;

namespace ServiesHost.Pages
{
    public class ProductCategoriyModel : PageModel
    {
        public ProductCategoriyModel productCategoriy;
        private readonly IProductCategoryQure _productCategoryQure;

        public ProductCategoriyModel(IProductCategoryQure  productCategoryQure )
        {
            _productCategoryQure = productCategoryQure;
        }

        public void OnGet(string id)
        {
            var productCategory= _productCategoryQure.GetProductCategoriyWithBayProducts(id);
        }
    }
}
