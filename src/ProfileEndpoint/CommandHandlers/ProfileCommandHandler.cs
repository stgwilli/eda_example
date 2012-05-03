using Messages.Commands;
using NServiceBus;
using Raven.Client;

namespace ProfileEndpoint.CommandHandlers
{
    public class ProfileCommandHandler : IHandleMessages<AddProfile>
    {
        IDocumentSession session;

        public ProfileCommandHandler(IDocumentSession session)
        {
            this.session = session;
        }

        public void Handle(AddProfile message)
        {
            session.Store(message.profile_information);           
        }
    }
}