using DapperExtensions.Mapper;
using MyAbpProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public class NavigationMapper:ClassMapper<NavigationInfo>
    {
        public NavigationMapper()
        {
            Table("NavigationInfo");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
