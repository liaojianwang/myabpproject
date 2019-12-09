using DapperExtensions.Mapper;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.DapperCore.Mappings
{
    public sealed class ArticleGoodsSpecMapper : ClassMapper<ArticleGoodsSpecInfo>
    {
        public ArticleGoodsSpecMapper()
        {
            Table("dt_article_goods_spec");
            Map(c => c.Id).Key(KeyType.Assigned);
            AutoMap();
        }
    }
}
