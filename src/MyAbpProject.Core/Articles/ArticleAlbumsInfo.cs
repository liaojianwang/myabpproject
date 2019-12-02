using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject.Articles
{
    /// <summary>
    /// 图片相册
    /// </summary>
    [Serializable]
    [Table("dt_article_albums")]
    public class ArticleAlbumsInfo : BaseEntity
    {
        #region Model
        private int _channel_id = 0;
        private int _article_id = 0;
        private string _thumb_path = string.Empty;
        private string _original_path = string.Empty;
        private string _remark = string.Empty;
        private DateTime _add_time = DateTime.Now;
        
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
        /// 缩略图地址
        /// </summary>
        [MaxLength(MaxValueLength)]
        public string thumb_path
        {
            set { _thumb_path = value; }
            get { return _thumb_path; }
        }
        /// <summary>
        /// 原图地址
        /// </summary>
        [MaxLength(MaxValueLength)]
        public string original_path
        {
            set { _original_path = value; }
            get { return _original_path; }
        }
        /// <summary>
        /// 图片描述
        /// </summary>
        [MaxLength(MaxValueLength)]
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion
    }
}
