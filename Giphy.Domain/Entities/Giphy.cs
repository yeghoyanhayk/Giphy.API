using Giphy.Domain.Entities.Base;
using System;

namespace Giphy.Domain.Entities
{
    public class Giphy : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string QueryString { get; set; }
        public string StoragePath { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
    }
}
