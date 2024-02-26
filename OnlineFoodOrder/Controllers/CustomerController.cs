using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrder.Models;
using OnlineFoodOrder.Models.Domain;

public class CustomerController : Controller
{
    [HttpPost]
    public IActionResult CustomerAdd(AddCustomerView addCustomerView)
    {
        // Redirect to OrderAdd action with query string parameters
        return RedirectToAction("OrderAdd", "Order", new
        {
            customerName = addCustomerView.name,
            customerPhone = addCustomerView.phone,
            customerEmail = addCustomerView.email,
            customerAddress = addCustomerView.Address
        });
    }



    [HttpGet]
    public IActionResult CustomerAdd()
    {
        return View();
    }
}
