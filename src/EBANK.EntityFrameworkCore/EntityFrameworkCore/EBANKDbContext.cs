using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EBANK.Authorization.Roles;
using EBANK.Authorization.Users;
using EBANK.MultiTenancy;

namespace EBANK.EntityFrameworkCore
{
    public class EBANKDbContext : AbpZeroDbContext<Tenant, Role, User, EBANKDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EBANKDbContext(DbContextOptions<EBANKDbContext> options)
            : base(options)
        {
        }
    }
}
