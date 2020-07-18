using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LearningBoilerplate.Configuration;

namespace LearningBoilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(LearningBoilerplateWebCoreModule))]
    public class LearningBoilerplateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LearningBoilerplateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LearningBoilerplateWebHostModule).GetAssembly());
        }
    }
}
