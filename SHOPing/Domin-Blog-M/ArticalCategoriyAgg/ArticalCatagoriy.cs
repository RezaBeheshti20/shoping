using _0_Frimwork.Domin;
using Domin_Blog_M.ArticalAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin_Blog_M.ArticalCategoriyAgg
{
    public class ArticalCatagoriy:EntityBase
    {
        public string Name { get;private set; }
        public string Picture { get;private set; }
        public string Description { get;private set; }
        public int ShowOrder { get;private set; }
        public string Slug { get;private set; }
        public string MetaDiscripiton { get;private set; }
        public string Keywords { get;private set; }
        public string CanonicalAddress { get;private set; }
        public List<Artical> Articals { get; private set; }

        public ArticalCatagoriy(string name, string picture, string description, int showOrder, string slug, string metaDiscripiton, string keywords, string canonicalAddress)
        {
            Name = name;
            Picture = picture;
            Description = description;
            ShowOrder = showOrder;
            Slug = slug;
            MetaDiscripiton = metaDiscripiton;
            Keywords = keywords;
            CanonicalAddress = canonicalAddress;
        }
        public void Edit(string name, string picture, string description, int showOrder, string slug, string metaDiscripiton, string keywords, string canonicalAddress)
        {
            Name = name;
            if(!string.IsNullOrEmpty(picture)) 
            Picture = picture;
            Description = description;
            ShowOrder = showOrder;
            Slug = slug;
            MetaDiscripiton = metaDiscripiton;
            Keywords = keywords;
            CanonicalAddress = canonicalAddress;
        }
    }
}
