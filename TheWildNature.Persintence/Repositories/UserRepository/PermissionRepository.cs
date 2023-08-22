using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Domain.Entities.Users;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.UserRepository
{
    public class PermissionRepository:GenericRepository<Permission>,IPermissionRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public PermissionRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
