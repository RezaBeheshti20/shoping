using _01_LampQuery.Conterctes.Artical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.ArticalCategoriy
{
    public class ArticalCategoriyQureModel
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
        public string Slug { get; set; }
        public string MetaDiscripiton { get; set; }
        public List<string> KeywordList { get; set; }
        public string Keywords { get; set; }
        public string CanonicalAddress { get; set; }
        public string ArticalCount { get; set; }
        public List<ArticalQuryModel> Articals { get; set; }    
    }
}
