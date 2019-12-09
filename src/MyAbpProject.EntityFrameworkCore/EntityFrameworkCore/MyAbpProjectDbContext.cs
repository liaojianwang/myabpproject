using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpProject.Authorization.Roles;
using MyAbpProject.Authorization.Users;
using MyAbpProject.MultiTenancy;
using MyAbpProject.Articles;

namespace MyAbpProject.EntityFrameworkCore
{
    public class MyAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public MyAbpProjectDbContext(DbContextOptions<MyAbpProjectDbContext> options)
            : base(options)
        {
        }
        public DbSet<ArticleInfo> ArticleInfo { get; set; }
        public DbSet<ArticleAlbumsInfo> ArticleAlbumsInfo { get; set; }
        public DbSet<ArticleAttachInfo> ArticleAttachInfo { get; set; }
        public DbSet<ArticleGoodsInfo> ArticleGoodsInfo { get; set; }
        public DbSet<ArticleGoodsSpecInfo> ArticleGoodsSpecInfo { get; set; }
        public DbSet<UserGroupPriceInfo> UserGroupPriceInfo { get; set; }
    }
}
