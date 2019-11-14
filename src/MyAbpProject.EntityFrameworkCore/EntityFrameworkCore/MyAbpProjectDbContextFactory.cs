using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyAbpProject.Configuration;
using MyAbpProject.Web;

namespace MyAbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyAbpProjectDbContextFactory : IDesignTimeDbContextFactory<MyAbpProjectDbContext>
    {
        public MyAbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyAbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyAbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyAbpProjectConsts.ConnectionStringName));

            return new MyAbpProjectDbContext(builder.Options);
        }
    }
}
