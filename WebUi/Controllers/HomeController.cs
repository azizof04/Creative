using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUi.Data;
using WebUi.Models;

namespace WebUi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly CreativeDbContext _context;
    public HomeController(CreativeDbContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
        return View();
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
