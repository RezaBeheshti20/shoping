
using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_Application.Conterxt.Comment
{
    public interface ICommentApplication
    {
        OpratinResult Add (AddComment comment);
        OpratinResult Confirm(long id);
        OpratinResult Cancel(long id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);

    }
}
