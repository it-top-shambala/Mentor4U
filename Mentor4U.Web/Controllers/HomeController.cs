using System.Diagnostics;
using System.Linq;
using Mentor4U.Lib;
using Mentor4U.Web.Models;

using Microsoft.AspNetCore.Mvc;

namespace Mentor4U.Web.Controllers;

public class HomeController : Controller
{
    private readonly DataBaseContext _db;
    
    public HomeController(DataBaseContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var mentors = _db.Mentors.ToList();
        ViewBag.Mentors = mentors;
        
        return View();
    }

    [HttpPost]
    public IActionResult Index(Mentor mentor)
    {
        _db.Mentors.Add(mentor);
        _db.SaveChanges();
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
