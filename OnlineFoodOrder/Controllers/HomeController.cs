using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrder.Data;
using OnlineFoodOrder.Models;
using System.Diagnostics;

namespace OnlineFoodOrder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MVCDemoDbContext _mVCDemoDbContext;
        public HomeController(ILogger<HomeController> logger,MVCDemoDbContext mVCDemoDbContext)
        {
            _logger = logger;
            _mVCDemoDbContext = mVCDemoDbContext;
        }

        public async Task< IActionResult> Index()
        {
            var restaurant = await _mVCDemoDbContext.Restaurants.ToListAsync();
            return View(restaurant);

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
