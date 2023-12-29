using _01_LampQuery.Conterctes.Product;
using _01_LampQuery.Conterctes.ProductCategoryQure;
using _01_LampQuery.Conterctes.Slid;
using _01_LampQuery.Qure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SHop__m_Domin.ProductAgg;
using SHop__m_Domin.ProductCategoryAgg;
using SHop__m_Domin.ProductPicturAgg;
using SHop__m_Domin.SlidAgg;
using Shop__M_infrasutacher;
using Shop__M_infrasutacher.Repository;
using Shop__M_infrasutacher.RepositoryBase;
using Shop_M__Applicaion__Cotexet.Product;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using Shop_M__Applicaion__Cotexet.Slid;
using Shop_M_Application;
using System;
using System.Linq;

namespace Shop__M_ConFigoriton
{
    public class Shop_M_Boosterapper
    {
         

        public static void Configure(IServiceCollection service,string connectionString)
        {
            service.AddTransient<IProductCategoryApplicaton, IProductCategoryApplication>();
            service.AddTransient<IProuctCategoryReposetory, ProductCategoryRepository>();

            service.AddTransient<IProductApplication , ProductApplication>();
            service.AddTransient<IProductRepostori,ProductReposetory>();

            service.AddTransient<IProductPicturApplication , ProductPicturApplication>();
            service.AddTransient<IProductPicturRpostory , ProductPicturRepostory>();

            service.AddTransient<ISlidApplication,SlidApplication>();
            service.AddTransient<ISlidRepostory,SlidRepostory>();


            service.AddTransient<ISlidQure,SlidQure>();
            service.AddTransient<IProductCategoryQure, ProductCategoryQure>();
            service.AddTransient<IProductQure , ProductQure>();




            service.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));

        }

         
    }
}
