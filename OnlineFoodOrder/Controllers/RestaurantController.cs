using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrder.Data;
using OnlineFoodOrder.Models;
using OnlineFoodOrder.Models.Domain;

namespace OnlineFoodOrder.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly MVCDemoDbContext mVCDemoDbContext;
       
        public RestaurantController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mVCDemoDbContext = mVCDemoDbContext;
            

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var restuarant=await mVCDemoDbContext.Restaurants.ToListAsync();
            return View(restuarant);
        }
        
        [HttpGet]
        public IActionResult RestaurantAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RestaurantAdd(AddRestaurantView addRestaurantView) {
            var rest = new Restaurant()
            {
                Id = Guid.NewGuid(),
                RestaurantName = addRestaurantView.RestaurantName,
                Address = addRestaurantView.Address,
                Landmark = addRestaurantView.Landmark,
                State = addRestaurantView.State,
                City = addRestaurantView.City,
                Country = addRestaurantView.Country,
                PostalCode = addRestaurantView.PostalCode,
            };

            await mVCDemoDbContext.Restaurants.AddAsync(rest);
            await mVCDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index","Home");    
        }


        [HttpGet]
        public IActionResult View(Guid id)
        {
            return View();
        }






    }
}
