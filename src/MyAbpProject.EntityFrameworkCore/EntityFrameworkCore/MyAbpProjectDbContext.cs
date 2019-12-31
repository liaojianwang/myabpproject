using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpProject.Authorization.Roles;
using MyAbpProject.Authorization.Users;
using MyAbpProject.MultiTenancy;
using MyAbpProject.Articles;
using MyAbpProject.CmsEntities;
using MyAbpProject.Entities;

namespace MyAbpProject.EntityFrameworkCore
{
    public class MyAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public MyAbpProjectDbContext(DbContextOptions<MyAbpProjectDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ArticleInfo> ArticleInfo { get; set; }
        public virtual DbSet<ArticleAlbumsInfo> ArticleAlbumsInfo { get; set; }
        public virtual DbSet<ArticleAttachInfo> ArticleAttachInfo { get; set; }
        public virtual DbSet<ArticleGoodsInfo> ArticleGoodsInfo { get; set; }
        public virtual DbSet<ArticleGoodsSpecInfo> ArticleGoodsSpecInfo { get; set; }
        public virtual DbSet<UserGroupPriceInfo> UserGroupPriceInfo { get; set; }
        public virtual DbSet<ManagerInfo> ManagerInfo { get; set; }
        public virtual DbSet<NavigationInfo> NavigationInfo { get; set; }
    }
}
