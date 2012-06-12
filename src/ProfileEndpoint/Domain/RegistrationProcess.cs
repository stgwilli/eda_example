using System;

namespace RegistrationEndpoint.Domain
{
    public class RegistrationProcess
    {
        public string id { get; set; }
        public string profile_id { get; private set; }
        public DateTime registration_started { get; private set; }

        public RegistrationProcess(string profile_id)
        {
            this.profile_id = profile_id;
            registration_started = DateTime.Now;
        }
    }
}