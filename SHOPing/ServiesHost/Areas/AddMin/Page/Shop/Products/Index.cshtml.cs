using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M_Application;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public ProductSearChModel SareChModel;
        public List<ProductViewModel> products;
        public SelectList ProductCategorys;

        private readonly IProductCategoryApplication _productCategoryApplicaton;

        private readonly IProductApplication _productApplication;

        public List<ProductCategoryViewModel> Categorys { get; private set; }

        public IndexModel(IProductApplication productApplication,IProductCategoryApplication productCategoryApplication)
        {
          _productApplication = productApplication;
            _productCategoryApplicaton = productCategoryApplication;
        }

        public void OnGet(ProductSearChModel sareChModel)
        {
            ProductCategorys = new SelectList(_productCategoryApplicaton.GetProductCategories(),"Id", "Name");
           products=_productApplication.SearCh(sareChModel);
     
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreatProduct
            {
              Categorys = _productCategoryApplicaton.GetProductCategories()
            };

            return Partial("./Creat", command);
        }
        public  JsonResult OnPostCreat(CreatProduct command)
        {
            var result=_productApplication.Creat(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
            var product=_productApplication.Getdtails(Id);
            product.Categorys=_productCategoryApplicaton.GetProductCategories();
            return Partial("Edit", product);

        }
        public JsonResult OnPostEdit(EditProduct  command)
        {
            var REZA = _productApplication.Edit(command);
            return new JsonResult(REZA);
        }
        public IActionResult OnGetNotInStock(long Id)
        {
            var REza=_productApplication.NotInStock(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message=REza.Message;
            return RedirectToPage("./Index");
        }
        public IActionResult  OnOnGetIsInStock(long Id)
        {
            var REza = _productApplication.IsStock(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message = REza.Message;
            return RedirectToPage("./Index");
        }
    }
}
