using Microsoft.EntityFrameworkCore;
using TheWildNature.Domain.Entities.City;
using TheWildNature.Domain.Entities.Commons;
using TheWildNature.Domain.Entities.Customer;
using TheWildNature.Domain.Entities.Food;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Domain.Entities.PlaceDetails;
using TheWildNature.Domain.Entities.Users;
using TheWildNature.Domain.Entities.Wallet;

namespace TheWildNature.Persintence.Context
{
    public class TheWildNatureDbContext : DbContext
    {
        public TheWildNatureDbContext(DbContextOptions<TheWildNatureDbContext> options)
           : base(options)
        {

        }
        #region City
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        #endregion
        #region Kitchen
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<KitchenFinancialInfo> KitchenFinancialInfos { get; set; }
        public DbSet<KitchenManager> KitchenManagers { get; set; }
        public DbSet<KitchenStatus> KitchenStatuses { get; set; }
        public DbSet<KitchenLicence> KitchenLicences { get; set; }
        #endregion
        #region Food
        public DbSet<FoodClip> FoodClips { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodCategoryKitchen> FoodCategoryKitchens { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuFood> MenuFoods { get; set; }
        #endregion
        #region Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        #endregion
        #region PlaceDetail
        public DbSet<PlaceDetails> PlaceDetails { get; set; }
        public DbSet<PlaceDetailsUser> PlaceDetailsUser { get; set; }
        #endregion
        #region User
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion
        #region Wallet
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(TheWildNatureDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
