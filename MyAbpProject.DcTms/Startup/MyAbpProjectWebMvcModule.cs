using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MyAbpProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAbpProject.DcTms.Startup
{
    [DependsOn(typeof(MyAbpProjectWebCoreModule))]
    public class MyAbpProjectWebMvcModule : AbpModule
    {
        [Obsolete]
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        [Obsolete]
        public MyAbpProjectWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {

        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProjectWebMvcModule).GetAssembly());
        }
    }
}
