using TheWildNature.Domain.Entities.Commons;
using TheWildNature.Domain.Entities.Food;
namespace TheWildNature.Domain.Entities.Kitchen
{
    public class Kitchen : BaseDomainEntity
    {
        public string KitchenName { get; set; }
        public bool? exclusiveDelivery { get; set; }
        public int? NumberBranche { get; set; }
        public int CityId { get; set; }
        public int BusinessTypeId { get; set; }
        public int KitchenManagerId { get; set; }
        public int? KitchenFinancialInfoId { get; set; }
        public int? PlaceDetailsId { get; set; }
        public int? KitchenStatusId { get; set; }

        #region  Navigation Property
        public BusinessType? BusinessType { get; set; }
        public  KitchenStatus? KitchenStatus { get; set; }
        public City.City? City { get; set; }
        public KitchenFinancialInfo? KitchenFinancialInfo { get; set; }
        public List<Menu>? Menus { get; set; }
        public KitchenManager? KitchenManager { get; set; }
       public List<FoodCategoryKitchen>? FoodOfCategoryKitchens { get; set; }
        public PlaceDetails.PlaceDetails? PlaceDetails { get; set; }
        #endregion
    }
}