using NServiceBus;

namespace ProfileEndpoint
{
    public class EndpointConfiguration : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .StructureMapBuilder()
                .XmlSerializer()
                .MsmqTransport()
                .UnicastBus();
        }
    }
}