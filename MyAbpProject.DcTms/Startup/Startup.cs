using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore;
using Abp.AspNetCore.Mvc.Antiforgery;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyAbpProject.Common;
using MyAbpProject.Configuration;
using MyAbpProject.Identity;

namespace MyAbpProject.DcTms.Startup
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;
        private const string DefaultCorsPolicyName = "localhost";

        [Obsolete]
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();
            //MVC
            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
                //options.Filters.Add(new CorsAuthorizationFilterFactory(DefaultCorsPolicyName));
            }).AddJsonOptions(options =>
            {
                // Long类型的数值可能会超过JavaScript可表示的最大整数值，导致被截取。
                // 这里在返回JSON时将Long类型转换为String类型，就不会有这个问题了。
                //options.SerializerSettings.Converters.Add(new LongToStringConverter());
                //options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                //options.SerializerSettings.Converters.Add(new LongToStringConverter());
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession();

            IdentityRegistrar.Register(services);
            services.Configure<SecurityStampValidatorOptions>(options => options.ValidationInterval = TimeSpan.FromHours(12));

            services.AddAuthenticationCore().ConfigureApplicationCookie(o =>
            {
                o.ExpireTimeSpan = TimeSpan.FromHours(4);
                o.SlidingExpiration = true;
            });

            return services.AddAbp<MyAbpProjectWebMvcModule>(options =>
            {
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                    );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAbp(); //Initializes ABP framework.
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                //FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory()),
                //设置不限制content-type 该设置可以下载所有类型的文件，但是不建议这么设置，因为不安全
                //ServeUnknownFileTypes = true
                //下面设置可以下载apk和nupkg类型的文件
                ContentTypeProvider = new FileExtensionContentTypeProvider(
                    new Dictionary<string, string>
                    {
                       { ".apk","application/vnd.android.package-archive"},
                       { ".nupkg","application/zip"}
                    })
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "arearoute",
                        pattern: "{area:exists}/{controller}/{action=index}/{id?}"
                        );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
