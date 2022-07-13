using FlyingDutchmanAirlinesRefactoring.DataAccess.Context;
using FlyingDutchmanAirlinesRefactoring.DataAccess.Context.Extensions;
using FlyingDutchmanAirlinesRefactoring.Repositories.Extensions;
using FlyingDutchmanAirlinesRefactoring.Services.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FlyingDutchmanAirlinesRefactoring.Configs.Extensions
{
    public static class ServicesConfigExtension
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddFlyingDutchManDbContext(configuration.GetConnectionString("FlyingDutchmanDBConnectionString"));
            services.AddApplicationServices();
            services.AddApplicationRepositories();
            return services;
        }

    }
}
