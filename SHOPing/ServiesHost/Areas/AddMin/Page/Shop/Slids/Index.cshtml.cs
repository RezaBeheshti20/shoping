using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using Shop_M__Applicaion__Cotexet.Slid;
using Shop_M_Application;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.Shop.Slids 
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
      
        public List<SlidViewModel> Slids;
        private readonly ISlidApplication _slidApplication;

        public IndexModel(ISlidApplication slidApplication)
        {
            _slidApplication = slidApplication;
        }

        public void OnGet()
        {
            Slids = _slidApplication.Getlist();
     
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreatSlid();

            return Partial("./Creat", command);
        }
        public  JsonResult OnPostCreat(CreatSlid command)
        {
            var result= _slidApplication.Creat(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
            var product= _slidApplication .GetDetails(Id);  
            return Partial("Edit", product);

        }
        public JsonResult OnPostEdit(EditSlid  command)
        {
            var REZA = _slidApplication.Edit(command);
            return new JsonResult(REZA);
        }
        public IActionResult OnGetRemove(long Id)
        {
            var REza=_slidApplication.Remove(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message=REza.Message;
            return RedirectToPage("./Index");
        }
        public IActionResult  OnOnGetResork(long Id)
        {
            var REza = _slidApplication.Restor(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message = REza.Message;
            return RedirectToPage("./Index");
        }
    }
}
