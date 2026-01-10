using CodeChallenge.Application.Repositories;
using CodeChallenge.Infrastructure.InMemory;
using Microsoft.Extensions.DependencyInjection;


namespace CodeChallenge.Infrastructure.DI
{
   public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IMessageRepository, InMemoryMessageRepository>();
            return services;
        }
    }
}
