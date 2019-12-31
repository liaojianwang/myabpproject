using Abp.Configuration.Startup;
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
        /// <summary>
        /// 预加载方法
        /// </summary>
        public override void PreInitialize()
        {
            //如果你需要在调用接口而产生异常的时候展示异常的详细信息
            //Configuration.Modules.AbpWebCommon().SendAllExceptionsToClients = true;
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProjectWebMvcModule).GetAssembly());
        }
    }
}
