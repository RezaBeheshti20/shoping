using _0_Frimwork.Domin;
using Discunt_Application_Coteract.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicuntM_Domin.CustomerAgg
{
    public interface ICustomerRepostori:IRepository<long,Customer>
    {
        EditCustomer GetDitals(long id);

        List<CustomerViewModel> Search(CustomerSearchModel SearchModel);
    }
}
