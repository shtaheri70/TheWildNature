using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Kitchen
{
    public class BusinessType : BaseDomainEntity
    {
        public string BusinessTypeTitle { get; set; }

        #region  Navigation Property
        public List<Kitchen> Kitchen { get; set; }
        #endregion
    }
}