using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Customer
{
    public class OrderStatus : BaseDomainEntity
    {
        public int OrderStatusTitle { get; set; }

        #region  Navigation Property
        public List<Order> Orders { get; set; }
        #endregion
    }
}