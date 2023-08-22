using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheWildNature.Application.Contracts.Repositories;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Contracts.Repositories.FoodRepository;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Contracts.Repositories.OrderRepository;
using TheWildNature.Application.Contracts.Repositories.PlaceDetailsRepository;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Contracts.Repositories.WalletRepository;
using TheWildNature.Persintence.Context;
using TheWildNature.Persintence.Repositories;
using TheWildNature.Persintence.Repositories.CityRepository;
using TheWildNature.Persintence.Repositories.FoodRepository;
using TheWildNature.Persintence.Repositories.KitchenRepository;
using TheWildNature.Persintence.Repositories.OrderRepository;
using TheWildNature.Persintence.Repositories.PlaceDetailsRepository;
using TheWildNature.Persintence.Repositories.UserRepository;
using TheWildNature.Persintence.Repositories.WalletRepository;

namespace TheWildNature.Persintence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<TheWildNatureDbContext>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("TheWildNatureConnectionString"));
            });
            
            #region Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #region City
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            #endregion

            #region Food
            services.AddScoped<IFoodClipRepository, FoodClipRepository>();
            services.AddScoped<IFoodOfCategoryRepository, FoodOfCategoryRepository>();
            services.AddScoped<IMenuFoodRepository, MenuFoodRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            #endregion

            #region Kitchen
            services.AddScoped<IBussinessTypeRepository, BussinessTypeRepository>();
            services.AddScoped<IKitchenFinancialInfoRepository, KitchenFinancialInfoRepository>();
            services.AddScoped<IKitchenManagerRepository, KitchenManagerRepository>();
            services.AddScoped<IKitchenRepository, KitchenRepository>();
            services.AddScoped<IKitchenLicenceRepository, KitchenLicenceRepository>();
            #endregion

            #region Order
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();
            services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            #endregion

            #region PlaceDetails
            services.AddScoped<IPlaceDetailsRepository, PlaceDetailsRepositor>();
            #endregion

            #region User
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            #region Wallet
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IWalletTypeRepository, WalletTypeRepository>();
            #endregion

            
            #endregion

            return services;
        }
    }
}
