using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Backend2.Models;

namespace Backend2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}