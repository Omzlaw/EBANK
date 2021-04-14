using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EBANK.Configuration;
using EBANK.Web;

namespace EBANK.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EBANKDbContextFactory : IDesignTimeDbContextFactory<EBANKDbContext>
    {
        public EBANKDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EBANKDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EBANKDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EBANKConsts.ConnectionStringName));

            return new EBANKDbContext(builder.Options);
        }
    }
}
