using System;

namespace wlbs.Service.Domain.Core
{
    /// <summary>
    /// 聚合根，实体对象的抽象类，所有实体对象必须继承它。
    /// 包含两个基础属性：UUID-唯一实体Id，CreateTime-被创建的时间
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class AggregateRoot<TKey> : IAggregateRoot
    {
        /// <summary>
        /// UUID.
        /// </summary>
        public Guid UUId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}
