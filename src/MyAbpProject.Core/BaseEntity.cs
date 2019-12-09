using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject
{
    /// <summary>
    /// 实体基础类
    /// </summary>
    public class BaseEntity : Entity<long>, ISoftDelete
    {
        protected const int MaxTitleLength = 256;
        protected const int MaxDescriptionLength = 64 * 1024;
        protected const int MaxValueLength = 512;
        protected const int MaxNameLength = 256;
        protected const int ShortValueLength = 64;
        public BaseEntity()
        {
            Id = IdCreator.worker.NextId();
            CreatedTime = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get { return base.Id; } set { base.Id = value; } }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 软删除
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
