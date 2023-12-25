
using Discunt_Application_Coteract.Colleague;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.DisCunt.ColleagueDiscounts
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public ColleagueSearchModel SearchModel;
        public List<ColleagueViewModel> ColleagueDiscounts;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IColleagueApplication _colleagueApplication;

        public IndexModel(IProductApplication ProductApplication, IColleagueApplication colleagueApplication)
        {
            _productApplication = ProductApplication;
            _colleagueApplication = colleagueApplication;
        }

        public void OnGet(ColleagueSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            ColleagueDiscounts = _colleagueApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new DefinColleague
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(DefinColleague command)
        {
            var result = _colleagueApplication.Defin(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var colleagueDiscount = _colleagueApplication.GetDetials(id);
            colleagueDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", colleagueDiscount);
        }

        public JsonResult OnPostEdit(EditColleague command)
        {
            var result = _colleagueApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            _colleagueApplication.Remove(id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRestore(long id)
        {
            _colleagueApplication.Restore(id);
            return RedirectToPage("./Index");
        }
    }
}
