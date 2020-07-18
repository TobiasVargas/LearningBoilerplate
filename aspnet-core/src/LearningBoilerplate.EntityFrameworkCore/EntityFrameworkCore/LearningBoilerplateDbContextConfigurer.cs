using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LearningBoilerplate.EntityFrameworkCore
{
    public static class LearningBoilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LearningBoilerplateDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LearningBoilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
