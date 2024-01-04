using _0_Frimwork.Application;
using _01_LampQuery.Conterctes.Product;
using _01_LampQuery.Conterctes.ProductCategoryQure;
using Discontinfarstuacher;
using Discontinfarstuacher.Migrations;
using M_invantori.Infarastucher.EFcor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SHop__m_Domin.CommentAgg;
using SHop__m_Domin.ProductAgg;
using SHop__m_Domin.ProductPicturAgg;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class ProductQure : IProductQure
    {
        private readonly invantoriContext _invantoriContext;
        private readonly ShopContext _shopContext;
        private readonly DisCountContext _disCountContext;

        public ProductQure(ShopContext shopContext, invantoriContext invantoriContext, DisCountContext disCountContext)
        {
            _invantoriContext = invantoriContext;
            _shopContext = shopContext;
            _disCountContext = disCountContext;
        }

        public ProductQureModel GetDitails(string slug)
        {
            var invantorri = _invantoriContext.Invantoriyys.Select(x => new { x.ProductId, x.UnitParice ,x.InStock}).ToList();
            var discunt = _disCountContext.Customers.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId,x.EndDate }).ToList();
            var product = _shopContext.Products
                .Include(x => x.Category)
                .Include(x=>x.ProductPicturs)
                .Include(x=>x.Commants)
                .Select(product => new ProductQureModel
            {

                Id = product.Id,
                Name = product.Name,
                Categoriy = product.Category.Name,
                Picture = product.Picture,
                PicturAlt = product.PictureAlt,
                PicturTitel = product.PicturTitle,
                Slug = product.Slug,
                Code = product.Code,
                Description = product.Description,
                Keywords = product.Keywords,
                MetaDescription = product.MetaDescription,
                ShortDescription= product.ShortDescription,
                Commants=MapCommants(product.Commants),
                Pictures=MapProductPictures(product.ProductPicturs)
                 

            }).FirstOrDefault(x=>x.Slug == slug);
            if (product == null)
                return new ProductQureModel();

          
            

                var productinvantori = invantorri.FirstOrDefault(x => x.ProductId == product.Id);

                if (product.Price != null)
                {
                   product.IsInStok = productinvantori.InStock;
                    var price = productinvantori.UnitParice;
                    product.Price.ToString();
                    var discuntt = discunt.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discuntt != null)
                    {
                        int discuntRate = discuntt.DiscountRate;
                        product.DisCountRate = discuntRate;
                        product.DiscountExpireDate= discuntt.EndDate.ToDiscountFormat();
                        product.HasDiscount = discuntRate > 0;
                        var discuntAmout = Math.Round((price * discuntRate) / 100);
                        product.PriceWithDisCount = (price - discuntAmout).ToString();
                    }
                }



             
            return product;
        }

        private static List<CommantQureModel> MapCommants(List<Commant> commants)
        {
            return commants
                .Where(x => !x.IsCancel)
                .Where(x => x.IsConfirmad)
                .Select(x => new CommantQureModel
            {
                Name=x.Name,
                Massege=x.Mesasseg,
                 Id=x.Id,


            }).OrderByDescending(x=>x.Id).ToList();
        }

        private static List<ProductPictureQureModel> MapProductPictures(List<ProductPictur> products)
        {
           return products.Select(x => new ProductPictureQureModel 
           {
            IsRemove=x.IsRemove,
            PicturAlt=x.PicturAlt,
            Picture = x.Pictur,
            PicturTitel=x.PicturTitel,
            ProductId=x.ProductId,
           }).Where(x=>!x.IsRemove).ToList();
        }

        public List<ProductQureModel> GetLatesArrivals()
        {
            var invantorri = _invantoriContext.Invantoriyys.Select(x => new { x.ProductId, x.UnitParice }).ToList();
            var discunt = _disCountContext.Customers.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId }).ToList();
            var products = _shopContext.Products.Include(x => x.Category).Select(product => new ProductQureModel
            {

                Id = product.Id,
                Name = product.Name,
                Categoriy = product.Category.Name,
                Picture = product.Picture,
                PicturAlt = product.PictureAlt,
                PicturTitel = product.PicturTitle,
                Slug = product.Slug
            }).OrderByDescending(x=>x.Id).Take(6).ToList();

            foreach (var product in products)
            {
               
                var productinvantori = invantorri.FirstOrDefault(x => x.ProductId == product.Id);

                if (product.Price != null)
                {
                    var price = productinvantori.UnitParice;
                    product.Price.ToString();
                    var discuntt = discunt.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discuntt != null)
                    {
                        int discuntRate = discuntt.DiscountRate;
                        product.DisCountRate = discuntRate;
                        product.HasDiscount = discuntRate > 0;
                        var discuntAmout = Math.Round((price * discuntRate) / 100);
                        product.PriceWithDisCount = (price - discuntAmout).ToString();
                    }
                }

               

            }
            return products;
        }

        public List<ProductQureModel> SearCh(string Value)
        {

            var invantorri = _invantoriContext.Invantoriyys.Select(x => new { x.ProductId, x.UnitParice }).ToList();
            var discunt = _disCountContext.Customers.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId }).ToList();
            var Qure = _shopContext.Products.Include(x => x.Category).Select(product => new ProductQureModel
            {
                Id = product.Id,
                Categoriy = product.Category.Name,
                Name = product.Name,
                PicturAlt = product.PictureAlt,
                Picture = product.Picture,
                PicturTitel = product.PicturTitle,
                Slug = product.Slug
                
                


            }).AsNoTracking();


            if (!string.IsNullOrEmpty(Value))
                Qure = Qure.Where(x => x.Name.Contains(Value));
            var productt= Qure.OrderByDescending(x=>x.Id).ToList();



            foreach (var product in productt)
            {
                var productinvantori = invantorri.FirstOrDefault(x => x.ProductId == product.Id);

                if (product.Price != null)
                {
                    var price = productinvantori.UnitParice;
                    product.Price.ToString();
                    var discuntt = discunt.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discuntt != null)
                    {
                        int discuntRate = discuntt.DiscountRate;
                        product.DisCountRate = discuntRate;
                        product.HasDiscount = discuntRate > 0;
                        var discuntAmout = Math.Round((price * discuntRate) / 100);
                        product.PriceWithDisCount = (price - discuntAmout).ToString();
                    }
                }


               
            }

            return  productt;

        }
    }
}
  