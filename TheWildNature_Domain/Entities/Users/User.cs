using TheWildNature.Domain.Entities.Commons;
using TheWildNature.Domain.Entities.Customer;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Domain.Entities.PlaceDetails;

namespace TheWildNature.Domain.Entities.Users
{
    public class User: BaseDomainEntity
    {
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string ActiveCode { get; set; } 
        public bool IsActive { get; set; }
        public string? Password { get; set; }
        public int? CityId { get; set; }

        #region  Navigation Property
        public List<PlaceDetailsUser>? PlaceDetails { get; set; }
        public List<Wallet.Wallet>? Wallets { get; set; }
        public List<Order>? Orders { get; set; }
        public  List<UserRole>? UserRole { get; set; }
        public KitchenManager? KitchenManager { get; set; }
        public City.City? City { get; set; }

        #endregion

    }
}