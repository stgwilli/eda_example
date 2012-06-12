using System.Linq;
using System.Web.Mvc;
using NServiceBus;
using Web.UI.DependencyResolution;
using Web.UI.Infrastructure.Extensions;

namespace Web.UI.Infrastructure
{
    public static class NServiceBusMvcExtensions
    {
        public static Configure for_mvc(this Configure configure)
        {
            configure.Configurer.RegisterSingleton(typeof(IControllerActivator), new NServiceBusControllerActivator());
            Configure.TypesToScan
                .Where(t => typeof(IController).IsAssignableFrom(t))
                .each(c => configure.Configurer.ConfigureComponent(c, DependencyLifecycle.InstancePerCall));
            DependencyResolver.SetResolver(new SmDependencyResolver(IoC.initialize()));
            return configure;
        }
    }
}