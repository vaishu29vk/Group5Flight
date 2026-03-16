using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Group5Flight.Models;

namespace Group5Flight.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // The Dashboard link returns a View
    public IActionResult Index()
    {
        return View();
    }

    // The Privacy link returns Content to test routing
    public IActionResult Privacy()
    {
        return Content("Client Privacy Policy Content");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}