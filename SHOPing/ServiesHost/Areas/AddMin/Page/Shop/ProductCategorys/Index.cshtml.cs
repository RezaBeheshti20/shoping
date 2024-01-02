using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.Shop.ProductCategorys
{
    public class IndexModel : PageModel
    {
        public ProductCategorySareChModel SareChModel;
        public List<ProductCategoryViewModel> productCategories;
        private readonly IProductCategoryApplicaton _productCategoryApplicaton;


        public IndexModel(IProductCategoryApplicaton productCategoryApplicaton)
        {
            _productCategoryApplicaton = productCategoryApplicaton;
        }

        public void OnGet(ProductCategorySareChModel sareChModel)
        {
           productCategories=_productCategoryApplicaton.SearCh(sareChModel);
     
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Creat", new CreatProductCategory());
        }
        public  JsonResult OnPostCreat(CreatProductCategory command)
        {
            var result=_productCategoryApplicaton.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
            var productCategory=_productCategoryApplicaton.GetDetails(Id);
            return Partial("Edit", productCategory);

        }
        public JsonResult OnPostEdit(EditProductCatgory command)
        {
            if(ModelState.IsValid)
            {

            }
            var REZA=_productCategoryApplicaton.Edit(command);
            return new JsonResult(REZA);
        }

    }
}
