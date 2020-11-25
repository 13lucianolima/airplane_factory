using AirplaneFactory.Data;
using AirplaneFactory.Domain.Interfaces.Service;
using AirplaneFactory.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AirplaneFactory.Domain.Interfaces.Data;
using AirplaneFactory.Application.Interfaces;
using AirplaneFactory.Application.Services;
using AirplaneFactory.Application.AutoMapper;
using AutoMapper;

namespace AirplaneFactory.IoC
{
    public static class InjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddDbContext<AirplaneDbContext>(opt =>
            {
                var con = configuration.GetConnectionString("conn");
                opt.UseSqlServer(con, x => x.MigrationsAssembly("AirplaneFactory.Migrations"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAirplaneAppService, AirplaneAppService>();
            services.AddScoped<IAirplaneService, AirplaneService>();
        }
    }
}
