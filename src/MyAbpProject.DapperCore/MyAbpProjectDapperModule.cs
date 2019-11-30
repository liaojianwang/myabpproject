using Abp.Dapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyAbpProject.DapperCore
{
    [DependsOn(typeof(MyAbpProjectCoreModule), typeof(AbpDapperModule))]
    public class MyAbpProjectDapperModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(MyAbpProjectDapperModule).GetAssembly() });
        }
    }
}
