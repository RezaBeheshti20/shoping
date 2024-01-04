using _0_Frimwork.Domin;
using Shop_M__Applicaion__Cotexet.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.CommentAgg
{
    public interface ICommentRepostoriy:IRepository<long,Commant>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
