using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class ArticleAlbumsMapper : ClassMapper<ArticleAlbumsInfo>
    {
        public ArticleAlbumsMapper()
        {
            Table("dt_article_albums");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
