using NServiceBus;

namespace RegistrationEndpoint
{
    public class EndpointConfiguration : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .StructureMapBuilder()
                .RavenSubscriptionStorage()
                .XmlSerializer()
                .MsmqTransport()
                .UnicastBus();
        }
    }
}