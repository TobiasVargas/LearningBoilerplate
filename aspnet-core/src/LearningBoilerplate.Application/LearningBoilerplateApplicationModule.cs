using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LearningBoilerplate.Authorization;

namespace LearningBoilerplate
{
    [DependsOn(
        typeof(LearningBoilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LearningBoilerplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LearningBoilerplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LearningBoilerplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
