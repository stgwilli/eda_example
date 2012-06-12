using System;

namespace RegistrationEndpoint.Infrastructure
{
    public interface IRepresentAnAggregate
    {
        Guid id { get; }
    }
}