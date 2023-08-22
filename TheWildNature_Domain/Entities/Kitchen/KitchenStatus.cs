using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Kitchen
{
    public class KitchenStatus:BaseDomainEntity
    {
        public string  StatusTitle { get; set; }


        #region  Navigation Property
        public List<Kitchen> Kitchens { get; set; }
        #endregion
    }
}