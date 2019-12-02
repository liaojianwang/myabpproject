using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class ArticleMapper : ClassMapper<ArticleInfo>
    {
        public ArticleMapper()
        {
            Table("dt_article");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
