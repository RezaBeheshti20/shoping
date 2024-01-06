using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticaL
{
    public class ArticalViewModel
    {
        public long Id { get; set; }
        public string Titel { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public string PublisDate { get; set; }
        public string Category { get; set; }
        public long CategoriyId { get; set; }
    }
}
