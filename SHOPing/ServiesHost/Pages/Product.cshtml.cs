using _01_LampQuery.Conterctes.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_M__Applicaion__Cotexet.Comment;

namespace ServiesHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQureModel Product;
        private readonly ICommentApplication _commentApplication;
        private readonly IProductQure _productQure;

        public ProductModel(IProductQure productQure,ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
            _productQure = productQure;
        }

        public void OnGet(string id)
        {
            Product=_productQure.GetDitails(id);
        }
        public IActionResult OnPost(AddComment comment)
        {
            var Qure=_commentApplication.Add(comment);
            return RedirectToPage("/Product",new { Id = comment.ProductId });
        }
    }
}
