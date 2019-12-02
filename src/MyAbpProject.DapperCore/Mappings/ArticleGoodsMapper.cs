using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class ArticleGoodsMapper : ClassMapper<ArticleGoodsInfo>
    {
        public ArticleGoodsMapper()
        {
            Table("dt_article_goods");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
