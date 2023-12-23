using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Colleague
{
    public interface IColleagueApplication
    {
        OpratinResult Defin(DefinColleague command);
        OpratinResult Edit(EditColleague command);
        OpratinResult Remove(long Id);
        OpratinResult Restore(long Id);
        EditColleague GetDetials(long Id);
        List<ColleagueViewModel> Search(ColleagueSearchModel searchModel); 
    }
}
