using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EBANK.EntityFrameworkCore
{
    public static class EBANKDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EBANKDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EBANKDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
