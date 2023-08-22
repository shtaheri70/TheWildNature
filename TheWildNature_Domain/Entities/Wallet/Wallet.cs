using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Wallet
{
    public class Wallet:BaseDomainEntity
    {
        public bool IsPay { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        #region  Navigation Property
        public  WalletType WalletType { get; set; }   
        public  Users.User User { get; set; }
        #endregion

    }
}