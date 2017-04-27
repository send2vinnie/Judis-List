using Abp.Authorization;
using Blargo.JudisList.Authorization.Roles;
using Blargo.JudisList.Authorization.Users;
using Blargo.JudisList.MultiTenancy;

namespace Blargo.JudisList.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
