using TheWildNature.Domain.Entities.Commons;
using TheWildNature.Domain.Entities.Food;

namespace TheWildNature.Domain.Entities.Customer
{
    public class OrderDetails : BaseDomainEntity
    {
        public int Price { get; set; }
        public int Count { get; set; }
        public int OrderId { get; set; }
        public int MenuFoodId { get; set; }

        #region  Navigation Property
        public Order Orders { get; set; }
        public MenuFood Food { get; set; }
        #endregion
    }
}