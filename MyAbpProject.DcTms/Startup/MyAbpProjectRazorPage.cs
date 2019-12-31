using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAbpProject.DcTms.Startup
{
    public abstract class MyAbpProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyAbpProjectRazorPage()
        {
            LocalizationSourceName = MyAbpProjectConsts.LocalizationSourceName;
        }
    }
}
