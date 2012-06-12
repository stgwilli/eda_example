using System.Web.Mvc;
using Web.UI.DependencyResolution;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Web.UI.App_Start.StructuremapMvc), "start")]

namespace Web.UI.App_Start
{
    public static class StructuremapMvc
    {
        public static void start()
        {
            var container = IoC.initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}