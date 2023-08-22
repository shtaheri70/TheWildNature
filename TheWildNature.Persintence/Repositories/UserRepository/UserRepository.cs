using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Generator;
using TheWildNature.Application.Security;
using TheWildNature.Domain.Entities.Users;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public UserRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> ActiveAccount(string activeCode)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> IsExistUserWithMobile(string mobile)
        {
            return await _dbContext.Users.AnyAsync(u => u.Mobile == mobile);
        }

        public async Task<User> Authenticate(string mobile, string password = "")
        {
            string hashPassword = string.Empty;

            if (!password.IsNullOrEmpty())
                hashPassword = PasswordHelper.EncodePasswordMd5(password);

            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Mobile == mobile.Trim().ToLower()
                                                            && (hashPassword != string.Empty ? u.Password == hashPassword : true));

        }
      
    }
}
