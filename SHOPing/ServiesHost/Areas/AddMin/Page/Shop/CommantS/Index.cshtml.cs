using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiesHost.Pages;
using Shop_M__Applicaion__Cotexet.Comment;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using Shop_M__Applicaion__Cotexet.Slid;
using Shop_M_Application;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.Shop.CommantS
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<CommentViewModel> Comments;
        public CommentSearchModel searchModel;
        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
     
        }
      
    
        public IActionResult OnGetCanCel(long Id)
        {
            var REza = _commentApplication.Cancel(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message=REza.Message;
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetConFirm(long Id)
        {
            var REza = _commentApplication.Confirm(Id);
            if (REza.IsSuccedded)
                return RedirectToPage("./Index");
            Message = REza.Message;
            return RedirectToPage("./Index");
        }
    }
}
