using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Domain.Entities.Users;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.UserRepository
{
    public class RoleRepository:GenericRepository<Role>,IRoleRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public RoleRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
