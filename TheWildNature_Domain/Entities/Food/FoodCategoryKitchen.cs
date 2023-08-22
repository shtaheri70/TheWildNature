using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Food
{
    public class FoodCategoryKitchen : IBaseDomainEntity
    {
        public int Id { get ; set ; }
        public int FoodOfCategoryId { get; set; }
        public int KitchenId { get; set; }

        #region Navigation Property
        public FoodCategory FoodOfCategory { get; set; }
        public Kitchen.Kitchen Kitchen { get; set; }
        #endregion

    }
}
