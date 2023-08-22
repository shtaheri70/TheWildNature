using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.PlaceDetails
{
    public class PlaceDetailsUser : IBaseDomainEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlaceDetailsId { get; set; }

        #region  Navigation Property
        public Users.User User { get; set; }
        public PlaceDetails PlaceDetails { get; set; }
        #endregion

    }
}
