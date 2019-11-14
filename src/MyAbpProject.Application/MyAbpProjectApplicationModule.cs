using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject.Authorization;

namespace MyAbpProject
{
    [DependsOn(
        typeof(MyAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
