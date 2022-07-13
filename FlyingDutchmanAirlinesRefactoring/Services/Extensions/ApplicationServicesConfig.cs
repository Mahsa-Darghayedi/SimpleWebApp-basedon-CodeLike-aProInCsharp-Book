using FlyingDutchmanAirlinesRefactoring.Services.Implementation;
using FlyingDutchmanAirlinesRefactoring.Services.Interfaces;

namespace FlyingDutchmanAirlinesRefactoring.Services.Extensions
{
    public static class ApplicationServicesConfig
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}
