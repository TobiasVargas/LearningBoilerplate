using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LearningBoilerplate.Configuration;
using LearningBoilerplate.Web;

namespace LearningBoilerplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LearningBoilerplateDbContextFactory : IDesignTimeDbContextFactory<LearningBoilerplateDbContext>
    {
        public LearningBoilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LearningBoilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LearningBoilerplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LearningBoilerplateConsts.ConnectionStringName));

            return new LearningBoilerplateDbContext(builder.Options);
        }
    }
}
