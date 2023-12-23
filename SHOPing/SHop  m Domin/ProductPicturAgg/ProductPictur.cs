using _0_Frimwork.Domin;
using SHop__m_Domin.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductPicturAgg
{
    public class ProductPictur:EntityBase
    {
        public  long ProductId { get;private set; }
        public string Pictur { get; private set; }
        public string PicturAlt { get;private set; }
        public string PicturTitel { get;private set;}
        public bool IsRemove { get;private set; }
        public Product Product { get; private set; }

        public ProductPictur(long productId,string pictur,string picturalt,string picturtitel)
        {
            ProductId = productId;
            Pictur = pictur;
            PicturAlt = picturalt;
            PicturTitel = picturtitel;
            IsRemove = false;
        }

        public ProductPictur(string pictur, long productId, string picturAlt, string picturTitel)
        {
            Pictur = pictur;
            ProductId = productId;
            PicturAlt = picturAlt;
            PicturTitel = picturTitel;
        }

        public void Edit(long productId, string pictur, string picturalt, string picturtitel)
        {
            ProductId = productId;
            Pictur = pictur;
            PicturAlt = picturalt;
            PicturTitel = picturtitel;
     
        }
        public void Remove()
        { 
            IsRemove = true;

        }
        public void Restor()
        {
          IsRemove = false;
        }
    }
}
