using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject.Entities
{
    [Serializable]
    [Table("NavigationInfo")]
    public class NavigationInfo : BaseEntity
    {
        public NavigationInfo()
        {
            ParentId = 0;
            ChannelId = 0;
            SortId = 99;
            IsLock = 0;
        }
        
        /// <summary>
        /// 所属父导航ID
        /// </summary>
        public long ParentId { get; set; }
        /// <summary>
        /// 所属频道ID
        /// </summary>
        public long ChannelId { get; set; }
        /// <summary>
        /// 导航类别
        /// </summary>
        public string NavType { get; set; }
        /// <summary>
        /// 导航ID
        /// </summary>
        public string NavName { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string NavTitle { get; set; }
        /// <summary>
        /// 副标题
        /// </summary>
        public string SubTitle { get; set; }
        /// <summary>
        /// 图标地址
        /// </summary>
        public string IconUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 排序数字
        /// </summary>
        public int SortId { get; set; }
        /// <summary>
        /// 是否隐藏0显示1隐藏
        /// </summary>
        public int IsLock { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 权限资源
        /// </summary>
        public string ActionType { get; set; }
        /// <summary>
        /// 系统默认
        /// </summary>
        public int IsSys { get; set; }

    }
}
