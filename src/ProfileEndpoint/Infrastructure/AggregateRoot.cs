using System;

namespace RegistrationEndpoint.Infrastructure
{
    public abstract class AggregateRoot : IRepresentAnAggregate
    {
        protected DateTime version;

        protected AggregateRoot()
        {
            id = Guid.NewGuid();
        }

        public Guid id { get; private set; }
    }
}