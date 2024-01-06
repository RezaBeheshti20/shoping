using _0_Frimwork.Domin;
using Domin_Blog_M.ArticalCategoriyAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin_Blog_M.ArticalAgg
{
    public class Artical:EntityBase
    {
        public string Titel { get;private set; }
        public string ShortDescription { get;private set; }
        public string Description { get;private set; }
        public string Picture { get;private set; }
        public string PictureAlt { get;private set; }
        public string PictureTiTle { get;private set; }
        public string Slug { get;private set; }
        public string Kewords { get;private set; }
        public DateTime PublisDate { get;private set; }
        public string MetaDescription { get;private set; }
        public string   CanonicalAddras { get;private set; }
        public long CategoryId { get;private set; }
        public ArticalCatagoriy Catagoriy { get;private set; }

        public Artical(string titel, string shortDescription, string description, DateTime publisDate, string picture, string pictureAlt, string pictureTiTle, string slug, string kewords, string metaDescription, string canonicalAddras, long categoryId)
        {
            Titel = titel;
            ShortDescription = shortDescription;
            Description = description;
            PublisDate = publisDate;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTiTle = pictureTiTle;
            Slug = slug;
            Kewords = kewords;
            MetaDescription = metaDescription;
             CanonicalAddras = canonicalAddras;
            CategoryId = categoryId;
            
        }
        public void Edit(string titel, string shortDescription, DateTime publisDate, string description, string picture, string pictureAlt, string pictureTiTle, string slug, string kewords, string metaDescription, string canonicalAddras, long categoryId)
        {
            Titel = titel;
            ShortDescription = shortDescription;
            PublisDate= publisDate;
            Description = description;
            if (string.IsNullOrEmpty(picture)) 
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTiTle = pictureTiTle;
            Slug = slug;
            Kewords = kewords;
            MetaDescription = metaDescription;
            CanonicalAddras = canonicalAddras;
            CategoryId = categoryId;
        }
    }
}
