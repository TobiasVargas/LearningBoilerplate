using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LearningBoilerplate.Authorization.Roles;
using LearningBoilerplate.Authorization.Users;
using LearningBoilerplate.MultiTenancy;

namespace LearningBoilerplate.EntityFrameworkCore
{
    public class LearningBoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, LearningBoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LearningBoilerplateDbContext(DbContextOptions<LearningBoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
