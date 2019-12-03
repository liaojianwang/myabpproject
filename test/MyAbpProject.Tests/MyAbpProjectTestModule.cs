using System;
using Castle.MicroKernel.Registration;
using NSubstitute;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Configuration.Startup;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Abp.Zero.EntityFrameworkCore;
using MyAbpProject.EntityFrameworkCore;
using MyAbpProject.Tests.DependencyInjection;
using MyAbpProject.DapperCore;
using MyAbpProject.Configuration;
using Abp.Reflection.Extensions;

namespace MyAbpProject.Tests
{
    [DependsOn(
        typeof(MyAbpProjectApplicationModule),
        typeof(MyAbpProjectEntityFrameworkModule),
        typeof(AbpTestBaseModule),
        typeof(MyAbpProjectDapperModule)
        )]
    public class MyAbpProjectTestModule : AbpModule
    {
        public MyAbpProjectTestModule(MyAbpProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;
        }

        public override void PreInitialize()
        {
            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
            Configuration.UnitOfWork.IsTransactional = false;

            // Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<AbpZeroDbMigrator<MyAbpProjectDbContext>>();

            Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);

            CustomEFConnetionsConfig();
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }

        private void CustomEFConnetionsConfig()
        {
            var configura = AppConfigurations.Get(typeof(MyAbpProjectTestModule).Assembly.GetDirectoryPathOrNull());
            string strConn = configura["ConnectionStrings:Default"];
            Configuration.DefaultNameOrConnectionString = strConn;
        }
    }
}
