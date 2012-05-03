using Messages.InputModels;
using NServiceBus;

namespace Messages.Commands
{
    public class AddProfile : IMessage
    {
        public Profile profile_information { get; set; } 
    }
}