using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyAbpProject.EntityFrameworkCore
{
    public static class MyAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
