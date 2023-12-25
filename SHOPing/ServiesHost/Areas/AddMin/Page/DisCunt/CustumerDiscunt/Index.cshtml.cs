using DicuntM_Domin.Colleague;
using DicuntM_Domin.CustomerAgg;
using Discunt_Application_Coteract.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M_Application;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.DisCunt.CustumerDiscunt
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public CustomerSearchModel SareChModel;
        public List<CustomerViewModel> customers;
        public SelectList Products;


        private readonly ICustomerApplication _customerApplication;
        private readonly IProductApplication _productApplication;
  
        public IndexModel(IProductApplication productApplication, ICustomerApplication customerApplication)
        {
            _productApplication = productApplication;
            _customerApplication = customerApplication;
        }

        public void OnGet(CustomerSearchModel sareChModel)
        {
            Products = new SelectList(_productApplication.GetProducts(),"Id", "Name");
           customers= _customerApplication.Search(SareChModel);
     
        }
        public IActionResult OnGetCreate()
        {
            var command = new DefinCostomer
            {
                Products = _productApplication.GetProducts()
            };

            return Partial("./Creat", command);
        }
        public  JsonResult OnPostCreat(DefinCostomer command)
        {
            var result=_customerApplication.Defin(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
          var CustomerDiscunt=_customerApplication.GetDetails(Id);
            Customer.Products = _productApplication.GetProducts();

            return new JsonResult(CustomerDiscunt);

        }
        public JsonResult OnPostEdit( EditCustomer  command)
        {
            var REZA = _customerApplication.Edit(command);
            return new JsonResult(REZA);
        }
       
            
    }
}
