using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticaL
{
    public class CreatArtical
    {
        public string Titel { get;  set; }
        public string ShortDescription { get;  set; }
        public string Description { get; set; }
        public IFormFile Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTiTle { get;set; }
        public string Slug { get;  set; }
        public string Kewords { get; set; }
        public  string PublisDate { get;  set; }
        public string MetaDescription { get; set; }
        public string CanonicalAddras { get;  set; }
        public long CategoryId { get;  set; }
    }
}
