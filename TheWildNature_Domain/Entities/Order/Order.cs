using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Customer
{
    public class Order : BaseDomainEntity
    {
        public int OrderStatusId { get; set; }
        public bool IsFinally { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int OrderSum { get; set; }

        #region  Navigation Property
        public OrderStatus OrderStatus { get; set; }
        public  Users.User User { get; set; }
        public  List<OrderDetails> OrderDetails { get; set; }
        #endregion
    }
} 