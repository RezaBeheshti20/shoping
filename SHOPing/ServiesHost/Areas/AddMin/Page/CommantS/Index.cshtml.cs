using Commant_Application.Conterxt.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.CommantS
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
