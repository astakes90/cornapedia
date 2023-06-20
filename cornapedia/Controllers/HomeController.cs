using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cornapedia.Models;

namespace cornapedia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult BoiledCone()
    {
        return Redirect("https://www.allrecipes.com/recipe/222352/jamies-sweet-and-easy-corn-on-the-cob/");
    }

    public IActionResult ConeDog()
    {
        return Redirect("https://www.allrecipes.com/recipe/35149/corn-dogs/");
    }

    public IActionResult GrilledCone()
    {
        return Redirect("https://www.spendwithpennies.com/grilled-corn-on-the-cob/");
    }

    public IActionResult PoppedCone()
    {
        return Redirect("https://wholefully.com/movie-theatre-popcorn-home/");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

