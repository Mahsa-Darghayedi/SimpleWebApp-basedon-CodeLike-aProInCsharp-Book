using FlyingDutchmanAirlinesRefactoring.Repositories.Base;
using FlyingDutchmanAirlinesRefactoring.Repositories.Implementation;
using FlyingDutchmanAirlinesRefactoring.Repositories.Interfaces;

namespace FlyingDutchmanAirlinesRefactoring.Repositories.Extensions
{
    public static class ApplicationRepositoriesConfig
    {
        public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
