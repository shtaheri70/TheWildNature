using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.PlaceDetails
{
    public class PlaceDetails:BaseDomainEntity
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Title { get; set; }
        public string PlaceType { get; set; }
        public string AddressDetails { get; set; }
        public bool IsDefault{ get; set; }
        public string Phone { get; set; }

        #region  Navigation Property
        public List<PlaceDetailsUser> Users { get; set; }
        public List<Kitchen.Kitchen> Kitchens { get; set; }
        #endregion
    }
}
