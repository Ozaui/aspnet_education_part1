using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnet_education_part1.Models;

namespace aspnet_education_part1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
