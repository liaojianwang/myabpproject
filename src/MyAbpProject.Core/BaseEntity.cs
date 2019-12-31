using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
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
    public class BaseEntity : Entity<long>, IHasCreationTime, IHasModificationTime, IHasDeletionTime
    {
        protected const int MaxTitleLength = 256;
        protected const int MaxDescriptionLength = 64 * 1024;
        protected const int MaxValueLength = 512;
        protected const int MaxNameLength = 256;
        protected const int ShortValueLength = 64;
        public BaseEntity()
        {
            Id = IdCreator.worker.NextId();
            CreationTime = Clock.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get { return base.Id; } set { base.Id = value; } }

        /// <summary>
        /// 软删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }
    }
}
