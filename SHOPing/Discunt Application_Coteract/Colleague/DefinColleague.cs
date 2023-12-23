using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Colleague
{
    public class DefinColleague
    {
        public long ProductId { get; set; }
        public int DesCountReat { get; set; }
        public List<ProductViewModel>Products { get; set; }
    }
}
