using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Customer
{
    public class CustomerViewModel
    {
        public long ProductId { get; set; }
        public long Id { get; set; }
        public string Product { get; set; }
        public int DiscontRate { get; set; }
        public string StartDate { get; set; }
        public DateTime  StartDateGr { get; set; }
        public string EndDate { get; set; }
        public DateTime  EndDateGr { get; set; }
        public string Reason { get; set; }
    }
}
