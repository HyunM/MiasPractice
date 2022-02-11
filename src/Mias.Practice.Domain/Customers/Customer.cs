using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mias.Practice.Customers
{
    public class Customer : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public string Tel { get; set; }

        private Customer()
        {
            /* This constructor is for deserialization / ORM purpose */
        }

        internal Customer(
            Guid id,
            [NotNull] string name,
            [CanBeNull] string tel = null)
            : base(id)
        {
            SetName(name);
            Tel = tel;
            
        }

        internal Customer ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: CustomerConsts.MaxNameLength
            );
        }
    }
}