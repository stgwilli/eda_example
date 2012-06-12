using System.Web.Mvc;
using Messages.Commands;
using NServiceBus;
using Raven.Client;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class ProfileController : Controller
    {
        IDocumentSession session;
        IBus bus;

        public ProfileController(IDocumentSession session, IBus bus)
        {
            this.session = session;
            this.bus = bus;
        }

        public ActionResult index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(Profile profile_input_model)
        {
            session.Store(profile_input_model);
            bus.Send(new StartMemberRegistrationProcess(profile_input_model.id));
            return RedirectToAction("index");
        }
    }
}
