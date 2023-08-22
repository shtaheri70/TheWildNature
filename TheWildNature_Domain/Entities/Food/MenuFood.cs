using TheWildNature.Domain.Entities.Commons;
using TheWildNature.Domain.Entities.Customer;

namespace TheWildNature.Domain.Entities.Food
{
    public class MenuFood: BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PreparationTime { get; set; }
        public string ImageFileName { get; set; }
        public int Price { get; set; }
        public int MenuId { get; set; }

        #region  Navigation Property
        public List<FoodClip> FoodClips { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public Menu Menu { get; set; }
        #endregion

    }
}