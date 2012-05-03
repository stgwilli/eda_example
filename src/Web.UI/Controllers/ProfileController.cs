using System.Web.Mvc;
using Messages.Commands;
using Messages.InputModels;
using NServiceBus;

namespace Web.UI.Controllers
{
    public class ProfileController : Controller
    {
        public IBus bus { get; set; }

        public ActionResult index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(Profile profile_input_model)
        {
            bus.Send(new AddProfile { profile_information = profile_input_model });
            return RedirectToAction("index");
        }
    }
}
