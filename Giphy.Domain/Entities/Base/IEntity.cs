using System;

namespace Giphy.Domain.Entities.Base
{
    public interface IEntity<TEntityId> : IEntity
    {
        TEntityId Id { get; set; }
    }
    public interface IEntity
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
    }
}
