﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject.Articles
{
    /// <summary>
    /// 商品对应规格
    /// </summary>
    [Serializable]
    [Table("dt_article_goods_spec")]
    public class ArticleGoodsSpecInfo:BaseEntity
    {
        #region Model
        private int _channel_id = 0;
        private int _article_id = 0;
        private int _spec_id = 0;
        private int _parent_id = 0;
        private string _title = string.Empty;
        private string _img_url = string.Empty;
        /// <summary>
        /// 频道ID
        /// </summary>
        public int channel_id
        {
            set { _channel_id = value; }
            get { return _channel_id; }
        }
        /// <summary>
        /// 文章ID
        /// </summary>
        public int article_id
        {
            set { _article_id = value; }
            get { return _article_id; }
        }
        /// <summary>
        /// 规格ID
        /// </summary>
        public int spec_id
        {
            set { _spec_id = value; }
            get { return _spec_id; }
        }
        /// <summary>
        /// 规格父ID
        /// </summary>
        public int parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 规格标题
        /// </summary>
        [MaxLength(MaxTitleLength)]
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 规格图片
        /// </summary>
        [MaxLength(MaxValueLength)]
        public string img_url
        {
            set { _img_url = value; }
            get { return _img_url; }
        }
        #endregion
    }
}
