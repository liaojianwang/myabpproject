using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class ArticleAttachMapper : ClassMapper<ArticleAttachInfo>
    {
        public ArticleAttachMapper()
        {
            Table("dt_article_attach");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
