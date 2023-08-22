using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Kitchen
{
    public class KitchenFinancialInfo:BaseDomainEntity
    {
        public int AccountNumber { get; set; }
        public int CardNumber { get; set; }
        public string ShabaNumber { get; set; }
        public string BankName { get; set; }
        public string? CardFileName { get; set; }
        public string? BusinessLicenseFileName { get; set; }
       
        #region  Navigation Property
        public  Kitchen Kitchen { get; set; }
        #endregion
    }
}