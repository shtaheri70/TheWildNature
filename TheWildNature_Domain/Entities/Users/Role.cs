using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Users
{
    public class Role : BaseDomainEntity
    { 
        public string RoleTitle { get; set; }

        #region  Navigation Property
        public virtual List<RolePermission> RolePermission { get; set; }
        public virtual List<UserRole> UserRole { get; set; }
        #endregion

    }
}