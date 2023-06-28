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
        string[] photoFilenames = new string[]
        {
            "boilingCone.jpeg",
            "grilledCone.jpeg",
            "coneDog.jpeg",
            "popCone.png"
        };

        Dictionary<string, string> recipeUrls = new Dictionary<string, string>
        {
            { "boilingCone.jpeg", "https://www.allrecipes.com/recipe/222352/jamies-sweet-and-easy-corn-on-the-cob/" },
            { "grilledCone.jpeg", "https://www.spendwithpennies.com/grilled-corn-on-the-cob/" },
            { "coneDog.jpeg", "https://www.allrecipes.com/recipe/35149/corn-dogs/" },
            { "popCone.png", "https://wholefully.com/movie-theatre-popcorn-home/" }
        };

        ViewBag.PhotoFilenames = photoFilenames;
        ViewBag.RecipeUrls = recipeUrls;

        return View();
    }

    public IActionResult RedirectToRecipe(string recipeUrl)
    {
        return Redirect(recipeUrl);
    }

    [NonAction]
    public string GetRecipeUrl(string filename)
    {
        return filename switch
        {
            "boilingCone.jpeg" => "https://www.allrecipes.com/recipe/222352/jamies-sweet-and-easy-corn-on-the-cob/",
            "grilledCone.jpeg" => "https://www.spendwithpennies.com/grilled-corn-on-the-cob/",
            "coneDog.jpeg" => "https://www.allrecipes.com/recipe/35149/corn-dogs/",
            "popCone.png" => "https://wholefully.com/movie-theatre-popcorn-home/",
            _ => string.Empty,// Handle the case when no matching recipe URL is found
        };
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

