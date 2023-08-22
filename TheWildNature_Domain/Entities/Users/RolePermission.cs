using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Users
{
    public class RolePermission :IBaseDomainEntity
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public int RoleId { get; set; }

        #region  Navigation Property
        public  Permission Permission { get; set; }       
        public  Role Role { get; set; }
        #endregion
    }
}