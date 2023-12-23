using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using Shop_M_Application;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.Shop.ProductPicturs 
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public ProductPicturSearChModel SareChModel;
        public List<ProductPicturViewModel> productPicturs;
        public SelectList Products;

        public List<ProductPicturViewModel> ProductPicturs { get; private set; }

        private readonly IProductPicturApplication _productPicturApplication;
        private readonly IProductApplication _productApplicaton;

        public IndexModel( IProductApplication  productApplication,IProductPicturApplication productPicturApplication)
        {
            _productPicturApplication = productPicturApplication;
            _productApplicaton = productApplication;
        }

        public void OnGet(ProductPicturSearChModel sareChModel)
        {
            Products = new SelectList(_productApplicaton.GetProducts(),"Id", "Name");
             ProductPicturs= _productPicturApplication.SearCh(sareChModel);
     
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreatProductPictur
            {
               Products = _productApplicaton.GetProducts()
            };

            return Partial("./Creat", command);
        }
        public  JsonResult OnPostCreat(CreatProductPictur command)
        {
            var result= _productPicturApplication.Creat(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
            var productPictur=_productPicturApplication.GetDetails(Id);
            productPictur.Products=_productApplicaton.GetProducts();
            return Partial("Edit", productPictur);

        }
        public JsonResult OnPostEdit(EditProductPictur  command)
        {
            var REZA = _productPicturApplication.Edit(command);
            return new JsonResult(REZA);
        }
        public IActionResult OnGetRemove(long Id)
        {
            var REza=_productPicturApplication.Remove(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message=REza.Message;
            return RedirectToPage("./Index");
        }
        public IActionResult  OnOnGetResork(long Id)
        {
            var REza = _productPicturApplication.Restor(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message = REza.Message;
            return RedirectToPage("./Index");
        }
    }
}
