using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Kitchen
{
    public class KitchenLicence:BaseDomainEntity
    {
        public string? LicenseFileName { get; set; }

        #region  Navigation Property
        public Kitchen Kitchen { get; set; }
        #endregion
    }
}
