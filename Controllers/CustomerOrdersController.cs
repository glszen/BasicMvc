using BasicMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvc.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Emily",
                LastName = "Cooper",
                Email = "emilycooper@mail.com"
            };

            var order1 = new Order
            {
                Id = 1,
                ProductName = "Americano",
                Price = 95,
                Quantity = 1
            };

            var order2 = new Order
            {
                Id = 2,
                ProductName = " Oat Latte",
                Price = 105,
                Quantity = 1
            };

            var order3 = new Order
            {
                Id = 3,
                ProductName = "Espresso",
                Price = 65,
                Quantity = 1
            };


            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer ?? new Customer(),
                Orders = new List<Order> { order1, order2, order3 }
            };
            return View(viewModel);
        }
    }
}
