using _0_Frimwork.Domin;
using Invantoriy.Application.Conterxt.Invantory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invantoriy.Domin.InvantoriyAgg
{
    public interface IinvantoriyRepostori:IRepository<long,Invantoriy>
    {
        EditInvantoriy GetDetails(long id);
        Invantoriy GetBy(long id);
        List<InvantoriyViewModel> Saerch(InvantoriySearchModel searchModel);
    }
}
