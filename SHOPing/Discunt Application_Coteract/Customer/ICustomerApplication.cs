using _0_Frimwork.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Customer
{
    public interface ICustomerApplication
    {
        OpratinResult Defin(DefinCostomer command);
        OpratinResult Edit(EditCustomer command);
        EditCustomer GetDetails(long id);
        List<CustomerViewModel> Search(CustomerSearchModel searchModel);
    }
}
