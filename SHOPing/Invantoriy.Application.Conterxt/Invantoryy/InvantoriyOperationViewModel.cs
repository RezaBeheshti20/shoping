using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invantoriy.Application.Conterxt.Invantoryy
{
    public class InvantoriyOperationViewModel
    {
        public long Id { get; set; }
        public bool Opration { get;  set; }
        public long Count { get; set; }
        public long OprationId { get; set; }
        public  string OprationDate { get; set; }
        public long CurrentCount { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }
        public long  InvantoriyId { get; set; }
    }
}
