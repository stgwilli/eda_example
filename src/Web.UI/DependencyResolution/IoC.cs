using StructureMap;
using Web.UI.Infrastructure.DI;

namespace Web.UI.DependencyResolution
{
    public static class IoC
    {
        public static IContainer initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<WebRegistry>();
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.SingleImplementationsOfInterface();
                });

            });
            return ObjectFactory.Container;
        }
    }
}