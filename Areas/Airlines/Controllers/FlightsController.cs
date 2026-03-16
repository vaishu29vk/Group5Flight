using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airlines.Controllers
{
    [Area("Airlines")]
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            // Load airline dashboard view
            return View();
        }

        public IActionResult Manage()
        {
            var manageMessage = "Airline Manage Flights Content";
            return Content(manageMessage);
        }

        public IActionResult Regulation()
        {
            var regulationMessage = "Airline Regulation Content";
            return Content(regulationMessage);
        }
    }
}
