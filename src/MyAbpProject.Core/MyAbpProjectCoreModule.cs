using Abp.Domain.Uow;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using MyAbpProject.Authorization.Roles;
using MyAbpProject.Authorization.Users;
using MyAbpProject.Configuration;
using MyAbpProject.Localization;
using MyAbpProject.MultiTenancy;
using MyAbpProject.Timing;

namespace MyAbpProject
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MyAbpProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MyAbpProjectLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = MyAbpProjectConsts.MultiTenancyEnabled;
            Configuration.UnitOfWork.OverrideFilter(AbpDataFilters.MustHaveTenant, MyAbpProjectConsts.MultiTenancyEnabled);
            Configuration.UnitOfWork.OverrideFilter(AbpDataFilters.MayHaveTenant, MyAbpProjectConsts.MultiTenancyEnabled);

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProjectCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
