using Abp.Dapper.Repositories;
using Abp.Domain.Uow;
using MyAbpProject.Articles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.UI;
using Castle.Core.Logging;
using Abp.Domain.Repositories;
using Abp.Web.Models;

namespace MyAbpProject.ArticleServices
{
    /// <summary>
    /// 文章类实现
    /// </summary>
    public class ArticleService : IArticleService
    {
        private readonly IDapperRepository<ArticleInfo, long> _article;
        public ILogger Logger { get; set; }
        public ArticleService(IDapperRepository<ArticleInfo, long> article)
        {
            _article = article;
            Logger = NullLogger.Instance;
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int article_id)
        {
            return _article.Get(article_id) != null ? true : false;
        }

        //public bool Exists(string call_index)
        //{
        //    return _article.GetAll().Count() > 0;
        //}

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        [UnitOfWork]
        [DontWrapResult]
        public long Create(ArticleInfo article)
        {
            try
            {
                var idArticle = _article.InsertAndGetId(article);

                return idArticle;
            }
            catch (Exception ex)
            {
                Logger.ErrorFormat("添加文章类异常：{0},{1}", ex.Message, JsonConvert.SerializeObject(article));
                throw new UserFriendlyException(400, ex.Message);
            }
        }
    }
}
