using Abp.Application.Services;
using MyAbpProject.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.ArticleServices
{
    /// <summary>
    /// 文章类接口
    /// </summary>
    public interface IArticleService : IApplicationService
    {
        /// <summary>
        /// 文章创建
        /// </summary>
        /// <param name="article">文章类</param>
        /// <returns></returns>
        long Create(ArticleInfo article);
    }
}
