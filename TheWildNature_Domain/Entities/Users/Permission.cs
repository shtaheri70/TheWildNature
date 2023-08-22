using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.Users
{
    public class Permission:BaseDomainEntity
    {

        public string PermissionTitle { get; set; }

        #region  Navigation Property
        public virtual List<RolePermission> RolePermission { get; set; }
        #endregion
    }
}