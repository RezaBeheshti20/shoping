using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invantoriy.Application.Conterxt.Invantory
{
    public class InvantoriyViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
        public long CurntCunt { get; set; }
        public string CreationDate { get; set; }
    }
}
