using _0_Frimwork.Domin;
using SHop__m_Domin.CommentAgg;
using SHop__m_Domin.ProductCategoryAgg;
using SHop__m_Domin.ProductPicturAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductAgg
{
    public class Product:EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Code { get; private set; }
        public double UnitPrice { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string PicturTitle { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string ShortDescription { get; private set; }
        public long CategoreyId { get; private set; }
        public bool IsInStok { get; private set; }
        public ProductCategory Category { get; private set; }
        public string Slug { get; private set; }
        public List<ProductPictur>ProductPicturs { get; private set; }
         public List<Commant> Commants { get; private set; } 
        public Product(string name, string description, string picture, string pictureAlt
            , string picturTitle, string keywords, string metaDescription, string slug
            ,long categoreyId, double unitPrice,string code,string shortDescription)
        {
            Name = name;
            Description =  description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = picturTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            ShortDescription =  shortDescription;
            Code = code;
            UnitPrice = unitPrice;
            CategoreyId =  categoreyId;
            
        }
        public void Edit(string name, string dscription, string picture, string pictureAlt
          , string picturTitle, string keywords, string metaDescription, string slug
          , long categoryId, double unitPrice, string code, string shortDiscription)
        {
            Name = name;
            Description = dscription;
            if(!string.IsNullOrWhiteSpace(Picture)) 
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = picturTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            ShortDescription = shortDiscription;
            Code = code;
            UnitPrice = unitPrice;
            CategoreyId = categoryId;

        }
        public void InStok()
        {
            IsInStok = true;
        }
        public void NotIdStok()
        {
            IsInStok = false; 
        }

        
    }
}
