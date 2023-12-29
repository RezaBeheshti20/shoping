using _0_Frimwork.Domin;
using SHop__m_Domin.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductCategoryAgg
{
    public class ProductCategory: EntityBase
    {
        public List<Product> Products;

        public string Name { get;private set; }
        public string Description { get;private set; }

        public string Picture { get;private set; }
        public string PictureAlt { get;private set; }
        public string PictureTitle { get;private set; }
        public string PicturTitle { get;private set; }
        public string Keywords { get;private set; }
        public string MetaDescription { get;private set; }
        public List<Product> products { get; private set; }
        public string Slug { get;private set; }

        public ProductCategory()
        {
            products = new List<Product>();
        }
        public ProductCategory(string name, string dscription , string picture,string pictureAlt
            ,string picturTitle,string keywords,string metaDescription ,string slug)
        {
          Name = name;
            Description = dscription;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = picturTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;

        }
        public void Edit(string name, string dscription, string picture, string pictureAlt
            , string picturTitle, string keywords, string metaDescription, string slug)
        {
            Name = name;
            Description = dscription;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = picturTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }
    }
}

