using Messages.Commands;
using Messages.Events;
using NServiceBus;
using Raven.Client;
using RegistrationEndpoint.Domain;

namespace RegistrationEndpoint.CommandHandlers
{
    public class RegistrationCommandHandler : IHandleMessages<StartMemberRegistrationProcess>
    {
        IDocumentSession session;
        IBus bus;

        public RegistrationCommandHandler(IDocumentSession session, IBus bus)
        {
            this.session = session;
            this.bus = bus;
        }

        public void Handle(StartMemberRegistrationProcess message)
        {

            var registration_process = new RegistrationProcess(message.profile_id);
            session.Store(registration_process);
            bus.Publish(new MemberRegistrationStarted(registration_process.id));
        }
    }
}