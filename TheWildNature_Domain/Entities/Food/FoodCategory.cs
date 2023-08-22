using TheWildNature.Domain.Entities.Commons;
namespace TheWildNature.Domain.Entities.Food
{
    public class FoodCategory : BaseDomainEntity
    {
        //irani kabab pitza ...
        public string FoodOfTypeCategoryTitle { get; set; }
        public string ImageName { get; set; }

        #region Navigation Property
        public List<FoodCategoryKitchen> FoodOfCategoryKitchens { get; set; }
        #endregion
    }
}
