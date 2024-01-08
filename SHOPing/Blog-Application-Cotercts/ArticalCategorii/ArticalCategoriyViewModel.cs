using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticalCategorii
{
    public class ArticalCategoriyViewModel
    {
         public long Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Picture{ get; set; }
        public int ShowOrder { get; set; }
    }
}
