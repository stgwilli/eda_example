using System;
using NServiceBus.UnitOfWork;
using Raven.Client;

namespace ProfileEndpoint
{
    public class RavenUnitOfWork : IManageUnitsOfWork
    {
        IDocumentSession session;

        public RavenUnitOfWork(IDocumentSession session)
        {
            this.session = session;
        }

        public void Begin()
        {
            // noop
        }

        public void End(Exception ex = null)
        {
            if (ex == null)
                session.SaveChanges();
        }
    }
}