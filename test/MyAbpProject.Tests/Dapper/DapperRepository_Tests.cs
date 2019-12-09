using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace MyAbpProject.Tests.Dapper
{
    public class DapperRepository_Tests : MyAbpProjectTestBase
    {
        private readonly IArticleService _articleService;
        public DapperRepository_Tests()
        {
            _articleService = Resolve<IArticleService>();
        }

        [Fact]
        public void ShouldBeInsert()
        {
            var model = new ArticleInfo();
            var id = _articleService.Add(model);
        }
    }

    
}
