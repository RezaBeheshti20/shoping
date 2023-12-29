using _01_LampQuery.Conterctes.Product;
using _01_LampQuery.Conterctes.ProductCategoryQure;
using Discontinfarstuacher;
using M_invantori.Infarastucher.EFcor;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductAgg;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class ProductCategoryQure : IProductCategoryQure
    {
        private readonly invantoriContext _invantoriContext;
        private readonly ShopContext _shopContext;
        private readonly DisCountContext _disCountContext;

        public ProductCategoryQure(ShopContext shopContext,invantoriContext invantoriContext, DisCountContext disCountContext)
        {
           _invantoriContext = invantoriContext;
            _shopContext = shopContext;
            _disCountContext = disCountContext;
        }

        public List<ProductCategoryQureModel> GetProductCategories()
        {
         return _shopContext.ProductCategories.Select(c => new ProductCategoryQureModel 
         { 
         
          Name = c.Name,
          Pictur=c.Picture,
          PicturAlt=c.PictureAlt,
          PicturTitel=c.PicturTitle,
          MetaDescription=c.MetaDescription,
          Keywords=c.Keywords,
          Desciption=c.Description,
          Slug=c.Slug,
         
         
         }).ToList();
        }

        public List<ProductCategoryQureModel> GetProductCategoriysWithProducts()
        {
            var invantorri = _invantoriContext.Invantoriyys.Select(x => new {x.ProductId,x.UnitParice}).ToList();
            var discunt =_disCountContext.Customers.Where(x=>x.StartDate<DateTime.Now&&x.EndDate>DateTime.Now).Select(x=>new {x.DiscountRate,x.ProductId,x.EndDate}).ToList();
            var catagoris= _shopContext.ProductCategories.Include(x => x.products).ThenInclude(x => x.Category).Select(x => new ProductCategoryQureModel
            {
                Id = x.Id, 
                Name = x.Name,
                Products = MapProducts(x.products),
                Desciption=x.Description,
               MetaDescription = x.MetaDescription,
               Keywords = x.Keywords,
                


            }).ToList() ;

            foreach(var categorii in catagoris)
            {

                foreach(var product in categorii.Products)
                {
                    var productinvantori = invantorri.FirstOrDefault(x => x.ProductId == product.Id);
                   
                    if(product.Price != null)
                    {
                        var price = productinvantori.UnitParice;
                        product.Price.ToString();
                        var discuntt = discunt.FirstOrDefault(x => x.ProductId == product.Id);
                        if (discuntt != null)
                        {
                            int discuntRate = discuntt.DiscountRate;
                            product.DisCountRate = discuntRate;
                            product.DiscountExpireDate = discuntt.EndDate.ToString();
                            product.HasDiscount = discuntRate > 0;
                            var discuntAmout = Math.Round((price * discuntRate) / 100);
                            product.PriceWithDisCount = (price - discuntAmout).ToString();
                        }
                    }


                
                }
            }

            return catagoris;
        }

        private static  List<ProductQureModel> MapProducts(List<Product> products)
        {
            return products.Select(product=> new ProductQureModel
            {
              Id = product.Id,
              Categoriy= product.Category.Name,
              Name= product.Name,
              PicturAlt=product.PictureAlt,
              Picture=product.Picture,
              PicturTitel=product.PicturTitle,
              Slug=product.Slug
              
            }).ToList();
            
        }
     

        public ProductCategoryQureModel GetProductCategoriyWithBayProducts(string slug)
        {
            
       
                var invantorri = _invantoriContext.Invantoriyys.Select(x => new { x.ProductId, x.UnitParice }).ToList();
                var discunt = _disCountContext.Customers.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId }).ToList();
                var Categori = _shopContext.ProductCategories.Include(x => x.products).ThenInclude(x => x.Category).Select(x => new ProductCategoryQureModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Products = MapProducts(x.products)


                }).FirstOrDefault(x => x.Slug == slug);



                foreach (var product in Categori.Products)
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
                return Categori;
        }

       
    }
}
