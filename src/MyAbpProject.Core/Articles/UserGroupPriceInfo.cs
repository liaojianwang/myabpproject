using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject.Articles
{
    [Table("dt_user_group_price")]
    public class UserGroupPriceInfo : BaseEntity
    {
        #region Model
        private int _channel_id = 0;
        private int _article_id = 0;
        private int _goods_id = 0;
        private int _group_id = 0;
        private decimal _price = 0M;
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
        /// 商品ID
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 会员组ID
        /// </summary>
        public int group_id
        {
            set { _group_id = value; }
            get { return _group_id; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price
        {
            set { _price = value; }
            get { return _price; }
        }
        #endregion
    }
}
