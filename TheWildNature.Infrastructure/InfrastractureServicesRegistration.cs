using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Models;
using TheWildNature.Infrastructure.Sender.SMS;
using TheWildNature.Infrastructure.Services;

namespace TheWildNature.Infrastructure
{
    public static class InfrastractureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastractureServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.Configure<KavenegarSetting>(configuration.GetSection("KavenegarInfo"));
            services.AddTransient<ISMSSender, SMSSender>();
            services.AddTransient<IFilesServise, FileServices>();
            return services;
        }
    }
}
