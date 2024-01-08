
using _01_LampQuery;
using _01_LampQuery.Conterctes.ArticalCategoriy;
using _01_LampQuery.Conterctes.ProductCategoryQure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ServiesHost.ViewComponents
{
    public class MenuViewCompont:ViewComponent
    {
        private readonly IProductCategoryQure _productCategoryQure;
        private readonly IArticalCategoryQure _articalCategoryQure;

        public MenuViewCompont(IProductCategoryQure productCategoryQure,IArticalCategoryQure articalCategoryQure)
        {
            _articalCategoryQure = articalCategoryQure;
            _productCategoryQure = productCategoryQure;
        }

        

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
                AArticalCategoriyQures =_articalCategoryQure.GetArticalCategoriys(),
                ProductCategoryQure = _productCategoryQure.GetProductCategories

            };

            return View(result);
        }
    }
}
