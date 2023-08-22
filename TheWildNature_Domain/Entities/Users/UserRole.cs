using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Users
{
    public class UserRole:BaseDomainEntity
    {       
        public int RoleId { get; set; }
        public int UserId { get; set; }

        #region  Navigation Property
        public  Role Role { get; set; }     
        public  User User { get; set; }
        #endregion
    }
}