using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.Articles
{
    public class TestInfo : Entity<long>, IFullAudited
    {
        public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
