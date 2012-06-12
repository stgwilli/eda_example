using NServiceBus;

namespace Messages.Events
{
    public class MemberRegistrationStarted : IEvent
    {
        public MemberRegistrationStarted(string profile_id)
        {
            this.profile_id = profile_id;
        }

        public string profile_id { get; set; }
    }
}