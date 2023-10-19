using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
//!session Config 3
using Microsoft.AspNetCore.Http;
namespace RandomPasscode.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string Num = "ABCDEFGHIJKLMNOPQRSTUVWYZ0123456789";
        var RandomPasscode = new char[14];
        var rand = new Random();
        for (int i = 0; i < RandomPasscode.Length; i++)
        {
            RandomPasscode[i] = Num[rand.Next(Num.Length)];
        }
        string generatedPass = new string(RandomPasscode);
        return View("Index", generatedPass);
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
