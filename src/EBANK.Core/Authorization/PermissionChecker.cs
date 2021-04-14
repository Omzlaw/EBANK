using Abp.Authorization;
using EBANK.Authorization.Roles;
using EBANK.Authorization.Users;

namespace EBANK.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
