using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discunt_Application_Coteract.Colleague
{
    public class ColleagueViewModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Product { get; set; }
        public int DisCuontRate { get; set; }
        public string CreationDate { get; set; }
    }
}
