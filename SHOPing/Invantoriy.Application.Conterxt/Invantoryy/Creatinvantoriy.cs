using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invantoriy.Application.Conterxt.Invantory
{
    public class Creatinvantoriy
    {
        public long ProductId { get; set; }
        public double UnitPraice { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
