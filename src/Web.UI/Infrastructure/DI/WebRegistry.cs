using Raven.Client;
using Raven.Client.Document;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;

namespace Web.UI.Infrastructure.DI
{
    public class WebRegistry : Registry
    {
        public WebRegistry()
        {
            register_raven();
        }

        void register_raven()
        {
            ForSingletonOf<IDocumentStore>().Use(() =>
            {
                var store = new DocumentStore { ConnectionStringName = "RavenDB" }.Initialize();
                store.Conventions.FindIdentityProperty = p => p.Name == "id";
                return store;
            });
            For<IDocumentSession>().LifecycleIs(new HttpContextLifecycle()).Use(ctx => ctx.GetInstance<IDocumentStore>().OpenSession());
        }
    }
}