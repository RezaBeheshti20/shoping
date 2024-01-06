using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticalCategorii
{
    public class CreatArticalCategoriy
    {
        public string Name { get;  set; }
        public IFormFile Picture { get;   set; }
        public string PictureAlt { get; set; }
        public string PictureTiTel { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get;set; }
        public string Slug { get; set; }
        public string MetaDiscripiton { get; set; }
        public string Keywords { get; set; }
        public string CanonicalAddress { get;set; }
    }
}
