using _01_LampQuery.Conterctes.Comment;
using Commant_Domin.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.Artical
{
    public class ArticalQuryModel
    {
        public long Id { get; set; }
        public string Titel { get;  set; }
        public string ShortDescription { get;   set; }
        public string Description { get;  set; }
        public string Picture { get; set; }
        public string PictureAlt { get;  set; }
        public string PictureTiTle { get;  set; }
        public string Slug { get;  set; }
        public string Kewords { get;  set; }
        public List<string>Keywordlist { get; set; }
        public string PublisDate { get;  set; }
        public string MetaDescription { get;  set; }
        public string CanonicalAddras { get;  set; }
        public long CategoryId { get;  set; }
        public string CategoryName { get; set; }
        public string CategorytSlug { get; set; }
        public List<CommantQureModel> Commants { get; set; }
    }
}
