using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class UserGroupPriceMapper:ClassMapper<UserGroupPriceInfo>
    {
        public UserGroupPriceMapper()
        {
            Table("dt_user_group_price");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
