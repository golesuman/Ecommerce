using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

public class HomeController : Controller
{
    private readonly EcommerceDbContext dbContext;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, EcommerceDbContext dbContext)
    {
        _logger = logger;
        this.dbContext = dbContext;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Product()
    {
        // Console.WriteLine(await dbContext.Cloth.ToListAsync();
        return View(await dbContext.Cloth.ToListAsync());
    }

    public IActionResult ProductUpload()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
