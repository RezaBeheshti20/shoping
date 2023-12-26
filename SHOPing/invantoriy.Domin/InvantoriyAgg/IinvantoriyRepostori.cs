using _0_Frimwork.Domin;
using Domin_invantorii.InvantoriyAgg;
using Invantoriy.Application.Conterxt.Invantory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invantoriy.Domin.InvantoriyAgg
{
    public interface IinvantoriyRepostori:IRepository<long,Invantoriyy>
    {
        EditInvantoriy GetDetails(long id);
        Invantoriyy GetBy(long prductId);
        List<InvantoriyViewModel> Saerch(InvantoriySearchModel searchModel);
    }
}
