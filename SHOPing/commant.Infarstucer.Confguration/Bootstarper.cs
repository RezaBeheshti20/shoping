using Commant_Application;
using Commant_Application.Conterxt.Comment;
using Commant_Domin.CommentAgg;
using Commant_infarstucter_EFCore;
using Commant_infarstucter_EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.Design;

namespace commant.Infarstucer.Confguration
{
    public class Bootstarper
    {
        public static void Cofigure(IServiceCollection service, string connectionString)
        {
            service.AddTransient<ICommentApplication, CommantApplication>();
            service.AddTransient<ICommentRepostoriy, CommantRepostoriy>();

            service.AddDbContext<CoomentContext>(x => x.UseSqlServer(connectionString));
        }
    }
}