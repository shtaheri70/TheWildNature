using TheWildNature.Application.Contracts.Repositories.WalletRepository;
using TheWildNature.Domain.Entities.Wallet;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.WalletRepository
{
    public class WalletRepository : GenericRepository<Wallet>,IWalletRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public WalletRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}