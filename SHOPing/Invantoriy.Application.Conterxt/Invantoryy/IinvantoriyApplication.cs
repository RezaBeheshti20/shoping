using _0_Frimwork.Application;
using Invantoriy.Application.Conterxt.Invantoryy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invantoriy.Application.Conterxt.Invantory
{
    public interface IinvantoriyApplication
    {
        OpratinResult Edit(EditInvantoriy command);
        OpratinResult Creat(Creatinvantoriy command);
        OpratinResult Increasase(IncresaseInvantoriy command);
        OpratinResult Reduce(List<RedusInvantoriy> command);
        OpratinResult Reduce(RedusInvantoriy command);
        EditInvantoriy GetDetails(long id);
        List<InvantoriyViewModel> Saerch(InvantoriySearchModel searchModel);
        List<InvantoriyOperationViewModel> GetOperationLog(long invantoriyId);
    }
}
