using TheWildNature.Application.Contracts.Repositories.WalletRepository;
using TheWildNature.Domain.Entities.Wallet;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.WalletRepository
{
    public class WalletTypeRepository:GenericRepository<WalletType>,IWalletTypeRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public WalletTypeRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
