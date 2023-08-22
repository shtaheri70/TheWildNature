
using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Food
{
    public class Menu: BaseDomainEntity
    {
        public string MenuTitle { get; set; }
        public string IconFileName { get; set; }
        public int KitchenId { get; set; }

        #region  Navigation Property
        public Kitchen.Kitchen Kitchen { get; set; }
        public  List<MenuFood> MenuFoods { get; set; }
        #endregion
    }
}