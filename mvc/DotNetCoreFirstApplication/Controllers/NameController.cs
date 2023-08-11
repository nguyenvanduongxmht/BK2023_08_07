using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreFirstApplication.Models;

namespace DotNetCoreFirstApplication.Controllers;

public class NameController : Controller
{
    private readonly ILogger<NameController> _logger;

    public NameController(ILogger<NameController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult GetName()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GetName(student std)
    {
         ViewBag.thongbao =std.FullName + std.NoiSinh;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
