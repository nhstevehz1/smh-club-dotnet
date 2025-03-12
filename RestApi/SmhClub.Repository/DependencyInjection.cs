using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmhClub.Repository.IRepository;
using SmhClub.Repository.Repository;


namespace SmhClub.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddReppository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
