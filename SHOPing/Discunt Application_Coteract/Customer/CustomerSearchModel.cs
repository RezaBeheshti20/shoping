using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Customer
{
    public class CustomerSearchModel
    {
        public long Id { get; set; }  
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ProductId { get; set; }
    }
}
