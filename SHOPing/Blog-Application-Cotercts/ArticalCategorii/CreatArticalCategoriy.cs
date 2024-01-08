using _0_Frimwork.Application;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticalCategorii
{
    public class CreatArticalCategoriy
    {
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Name { get;  set; }

        public IFormFile Picture { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string PictureAlt { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string PictureTiTel { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Description { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public int ShowOrder { get;set; }

        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Slug { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string MetaDiscripiton { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Keywords { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string CanonicalAddress { get;set; }
    }
}
