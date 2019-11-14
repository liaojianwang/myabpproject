using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpProject.Authorization.Roles;
using MyAbpProject.Authorization.Users;
using MyAbpProject.MultiTenancy;

namespace MyAbpProject.EntityFrameworkCore
{
    public class MyAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyAbpProjectDbContext(DbContextOptions<MyAbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
