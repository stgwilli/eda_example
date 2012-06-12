using System.Web.Mvc;
using Raven.Client;
using StructureMap;

namespace Web.UI.Infrastructure.Filters
{
    public class RavenSessionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
                return;

            using (var session = ObjectFactory.GetInstance<IDocumentSession>())
                session.SaveChanges();
        }
    }
}