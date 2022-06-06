using Microsoft.AspNetCore.Mvc;
using MVCExample.Data;
using MVCExample.Models;
using System.Diagnostics;

namespace MVCExample.Controllers
{
  public class HomeController : Controller
  {

    private readonly MobileContext _db;


    public HomeController(MobileContext mobileContext)
    {
      _db = mobileContext;
    }

    public IActionResult Index()
    {
      var phones = _db.Phones;
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
}