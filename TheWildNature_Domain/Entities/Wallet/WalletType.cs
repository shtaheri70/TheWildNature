using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Wallet
{
    public class WalletType:BaseDomainEntity
    {
        public string Title { get; set; }

        #region  Navigation Property
        public virtual List<Wallet> Wallet { get; set; }
        #endregion
    }
}