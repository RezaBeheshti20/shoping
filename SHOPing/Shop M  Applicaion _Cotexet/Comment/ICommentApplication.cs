using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Comment
{
    public interface ICommentApplication
    {
        OpratinResult Add (AddComment comment);
        OpratinResult Confirm(long id);
        OpratinResult Cancel(long id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);

    }
}
