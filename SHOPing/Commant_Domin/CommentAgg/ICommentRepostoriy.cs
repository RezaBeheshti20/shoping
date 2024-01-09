using _0_Frimwork.Domin;
using Commant_Application.Conterxt.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_Domin.CommentAgg
{
    public interface ICommentRepostoriy:IRepository<long,Commant>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
