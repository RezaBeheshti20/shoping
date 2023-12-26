using invantoriy.Domin.InvantoriyAgg;
using Invantoriy.Application;
using Invantoriy.Application.Conterxt.Invantory;
using M_invantori.Infarastucher.EFcor;
using M_invantori.Infarastucher.EFcor.RePostori;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace invantoryi.i.infarastucher.Confegoration
{
    public class invantoriBottstraper
    {
        public static void Configure(IServiceCollection service,string connectionString)
        {
            service.AddTransient<IinvantoriyRepostori, invantoriRepostori>();
            service.AddTransient<IinvantoriyApplication ,invantoriAplication>();
            

            service.AddDbContext<invantoriContext>(x=>x.UseSqlServer(connectionString));

        }
    }
}
