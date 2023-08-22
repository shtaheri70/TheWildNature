using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.City
{
    public class City : BaseDomainEntity
    {
        public string CityName { get; set; }
        public int ProvinceId { get; set; }

        #region  Navigation Property
        public List<Users.User>? Users { get; set; }
        public  Province Province { get; set; }
        public List<Kitchen.Kitchen> Kitchens { get; set; }
        #endregion
    }
}
