using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Food
{
    public class FoodClip: BaseDomainEntity
    {
        public string ClipTitle { get; set; }
        public DateTime  TimeDuration{ get; set; }
        public string Description { get; set; }
        public string ClipFileName { get; set; }
        public int MenuFoodId { get; set; }


        #region  Navigation Property
        public MenuFood Food { get; set; }
        #endregion
    }
}