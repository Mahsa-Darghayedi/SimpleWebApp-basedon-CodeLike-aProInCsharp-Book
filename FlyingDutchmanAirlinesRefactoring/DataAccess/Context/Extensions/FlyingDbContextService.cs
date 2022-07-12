using Microsoft.EntityFrameworkCore;

namespace FlyingDutchmanAirlinesRefactoring.DataAccess.Context.Extensions
{
    public static class FlyingDbContextService
    {
        public static IServiceCollection AddFlyingDutchManDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<FlyingDutchManDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
