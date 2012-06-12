using NServiceBus;

namespace Messages.Commands
{
    public class StartMemberRegistrationProcess : ICommand
    {
        public string profile_id { get; set; }

        public StartMemberRegistrationProcess(string profile_id)
        {
            this.profile_id = profile_id;
        }
    }
}