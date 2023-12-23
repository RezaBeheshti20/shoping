using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Slid
{
    public interface ISlidApplication
    {
        OpratinResult Creat(CreatSlid command);
        OpratinResult Edit(EditSlid command);
        OpratinResult Remove(long id);
        OpratinResult Restor(long id);
        EditSlid GetDetails(long id);
        List<SlidViewModel>  Getlist();
    }
}
