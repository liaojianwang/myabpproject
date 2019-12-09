using Abp.Extensions;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAbpProject.EntityFrameworkCore.Seed.CmsData
{
    public class DefaultManagerBuilder
    {
        private readonly MyAbpProjectDbContext _context;

        public DefaultManagerBuilder(MyAbpProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            // Default tenant

            var defaultManager = _context.ManagerInfo.IgnoreQueryFilters().FirstOrDefault(t => t.user_name == "admin");
            if (defaultManager == null)
            {
                defaultManager = new CmsEntities.ManagerInfo()
                {
                    user_name = "admin",
                    Id = IdCreator.worker.NextId(),
                    password = ("111111").ToMd5()
                };

                _context.ManagerInfo.Add(defaultManager);
                _context.SaveChanges();
            }
        }
    }
}
