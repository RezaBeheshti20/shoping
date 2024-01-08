using Blog_Application;
using Blog_Application_Cotercts.ArticaL;
using Blog_Application_Cotercts.ArticalCategorii;
using blog_infarastucher_EFCore;
using blog_infarastucher_EFCore.Repostoriy;
using Domin_Blog_M.ArticalAgg;
using Domin_Blog_M.ArticalCategoriyAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.Design;

namespace blog_infarastucher_ConFiger
{
    public class BootAstraper
    {
        public static void Configure(IServiceCollection service ,string connectionStiring)
        {
            service.AddTransient<IArticalCategoriyApplicationcs, ArticalCategoriyApplication>();
            service.AddTransient<IArticalCategoriyRepostori, ArticalCatagoryRepostori>();

            service.AddTransient<IArticalApplication,  ArticalApplication>();
            service.AddTransient<IArticalRepostoriy, ArticalRepostoriy>();

           

            service.AddDbContext<blogContext>(x=>x.UseSqlServer(connectionStiring));
        }
    }
}
