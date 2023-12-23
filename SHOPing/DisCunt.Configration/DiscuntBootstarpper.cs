using DicuntM_Domin.Colleague;
using DicuntM_Domin.CustomerAgg;
using Discontinfarstuacher;
using Discontinfarstuacher.Repostoriy;
using Discunt_Application_Coteract.Colleague;
using Discunt_Application_Coteract.Customer;
using DisCuntApplicaton;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.Design;

namespace DisCunt.Configration
{
    public class DiscuntBootstarpper
    {
        public static void Configure(IServiceCollection service,string connectionString)
        {
            service.AddTransient<ICustomerApplication, CustomerApplication>();
            service.AddTransient<ICustomerRepostori, CostomerRepostori>();

            service.AddTransient<IColleagueApplication ,ColleagueApplicaton>();
            service.AddTransient<IColleagueRepostori,  ColleagueRepostori>();

            service.AddDbContext<DisCountContext>(x=>x.UseSqlServer(connectionString));
        }

    }
}
