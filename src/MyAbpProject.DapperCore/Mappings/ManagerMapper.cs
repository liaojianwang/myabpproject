using DapperExtensions.Mapper;
using MyAbpProject.CmsEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public class ManagerMapper:ClassMapper<ManagerInfo>
    {
        public ManagerMapper()
        {
            Table("ManagerInfo");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
