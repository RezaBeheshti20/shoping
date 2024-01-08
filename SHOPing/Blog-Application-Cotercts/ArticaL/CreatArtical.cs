using _0_Frimwork.Application;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application_Cotercts.ArticaL
{
    public class CreatArtical
    {
        [Required(ErrorMessage =ValidationMessege.IsRequired)]
        public string Titel { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string ShortDescription { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Description { get; set; }
        public IFormFile Picture { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string PictureAlt { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string PictureTiTle { get;set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Slug { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Kewords { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public  string PublisDate { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string MetaDescription { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string CanonicalAddras { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public long CategoryId { get;  set; }
    }
}
