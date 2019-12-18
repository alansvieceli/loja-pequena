using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StoredBuild.Data;
using StoredBuild.Domain.Interfaces;
using StoredBuild.Domain.Service;

namespace StoredBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string strConnection)
        {
            //Responsável por toda injeção de dependencia
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(strConnection));

            services.AddSingleton(typeof(IRepository<>), typeof(IRepository<>));
            services.AddSingleton(typeof(CategoryStorerService));

        }

    }
}
