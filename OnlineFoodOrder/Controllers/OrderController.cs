using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrder.Models;
using System.Text;

namespace OnlineFoodOrder.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult OrderAdd()

        { 


            List<Orders> fr = new List<Orders>();
            fr.Add(new Orders()
            {
                OrdersId = 1,
                OrdersName = "Biryani",
                IsCheck = false,
            });
            fr.Add(new Orders()
            {
                OrdersId = 2,
                OrdersName = "Shawarma",
                IsCheck = false,
            });
            fr.Add(new Orders()
            {
                OrdersId = 3,
                OrdersName = "Salads",
                IsCheck = false,
            });
            fr.Add(new Orders()
            {
                OrdersId = 4,
                OrdersName = "Beverages",
                IsCheck = false,
            });

            OrderList orList=new OrderList();
            orList.Ord = fr;

            return View(orList);
        }

        [HttpPost]
        public ActionResult OrderAdd(OrderList frl)
        {
            StringBuilder sb= new StringBuilder();
            foreach(var item in frl.Ord)
            {
                if (item.IsCheck)
                {
                    sb.Append(item.OrdersName + ",");
                }
            }
            ViewBag.OrderItem = "Ordered Food Items are " + sb.ToString();
            return View(frl);

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
