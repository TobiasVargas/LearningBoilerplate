using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LearningBoilerplate.EntityFrameworkCore;
using LearningBoilerplate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LearningBoilerplate.Web.Tests
{
    [DependsOn(
        typeof(LearningBoilerplateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LearningBoilerplateWebTestModule : AbpModule
    {
        public LearningBoilerplateWebTestModule(LearningBoilerplateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LearningBoilerplateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LearningBoilerplateWebMvcModule).Assembly);
        }
    }
}