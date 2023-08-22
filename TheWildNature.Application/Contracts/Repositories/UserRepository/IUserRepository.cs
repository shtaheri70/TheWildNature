using TheWildNature.Domain.Entities.Users;

namespace TheWildNature.Application.Contracts.Repositories.UserRepository
{
    public interface IUserRepository:IGenericRepository<User>
    {
        Task<bool> ActiveAccount(string activeCode);
        Task<bool> IsExistUserWithMobile(string mobile);
        Task<User> Authenticate(string mobile,string password);
    }
}
