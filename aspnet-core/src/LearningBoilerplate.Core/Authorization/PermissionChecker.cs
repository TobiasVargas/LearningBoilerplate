using Abp.Authorization;
using LearningBoilerplate.Authorization.Roles;
using LearningBoilerplate.Authorization.Users;

namespace LearningBoilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
