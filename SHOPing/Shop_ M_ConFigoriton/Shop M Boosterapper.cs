using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SHop__m_Domin.ProductCategoryAgg;
using Shop__M_infrasutacher;
using Shop__M_infrasutacher.Repository;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using Shop_M_Application;
using System;

namespace Shop__M_ConFigoriton
{
    public class Shop_M_Boosterapper
    {
         

        public static void Configure(IServiceCollection service,string connectionString)
        {
            service.AddTransient<IProductCategoryApplicaton, ProductCategoryApplication>();
            service.AddTransient<IProuctCategoryReposetory, ProductCategoryRepository>();

            service.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));

        }

        public static void Configureation()
        {
            throw new NotImplementedException();
        }
    }
}
