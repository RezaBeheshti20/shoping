using _0_Frimwork.Application;
using _0_Frimwork.Infrasutacher;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductAgg;
using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.RepositoryBase
{
    public class ProductReposetory : RepositoryBase<long, Product>, IProductRepostori
    {
        private readonly ShopContext _context;

        public ProductReposetory(ShopContext context):base(context) 
        {
            _context = context;
        }


        public EditProduct GetDetails(long id)
        {
            return _context.Products.Select(x => new EditProduct { 
            
             Id = id,
             Name = x.Name,
             MetaDescription = x.MetaDescription,
             Description = x.Description,
             PictureAlt = x.PictureAlt,
             PictureTitle = x.PictureTitle,
             ShortDescription = x.ShortDescription,
             Slug = x.Slug,
             UnitPrice = x.UnitPrice,
             CategoreyId = x.CategoreyId,
             Code = x.Code,
            } ).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductViewModel> GetProducts()
        {
          return _context.Products.Select(x=>new ProductViewModel
          {
              Id = x.Id,
              Name = x.Name,
          }).ToList();
        }

        public Product GetProductWihtCategory(long id)
        {
            return _context.Products.Include(x=>x.CategoreyId).FirstOrDefault(x=>x.Id == id);
        }

        public List<ProductViewModel> SearCh(ProductSearChModel searChModel)
        {
            var reza = _context.Products.Include(x => x.Category).Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category.Name,
                CategoryId = x.CategoreyId,
                Code = x.Code,
                Picture = x.Picture,
                UnitPrice = x.UnitPrice,
                ISInStock=x.IsInStok,
                CreationDate = x.CreationData.ToFarsi()

            }); 
            if (!string.IsNullOrWhiteSpace(searChModel.Name))
                reza = reza.Where(x => x.Name.Contains(searChModel.Name));
            if(!string.IsNullOrEmpty(searChModel.Code))
                reza=reza.Where(x=>x.Code.Contains(searChModel.Code));

            if (searChModel.CategoryId != 0)
                reza = reza.Where(x => x.CategoryId == searChModel.CategoryId);
                return reza.OrderByDescending(x => x.Id).ToList();
        }
    }
}
