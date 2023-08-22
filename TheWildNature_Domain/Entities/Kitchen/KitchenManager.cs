using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Kitchen
{
    public class KitchenManager: BaseDomainEntity
    {
        public int UserId { get; set; }
        public int? NationalNumber { get; set; }
        public string? Email { get; set; }

        #region  Navigation Property
        public Users.User User { get; set; }
        public List<Kitchen> Kitchens { get; set; }
        #endregion
    }
}