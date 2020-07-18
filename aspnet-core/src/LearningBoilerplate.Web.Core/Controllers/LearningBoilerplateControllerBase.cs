using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LearningBoilerplate.Controllers
{
    public abstract class LearningBoilerplateControllerBase: AbpController
    {
        protected LearningBoilerplateControllerBase()
        {
            LocalizationSourceName = LearningBoilerplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
