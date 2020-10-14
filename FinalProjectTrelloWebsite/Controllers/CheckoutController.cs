using System.Collections.Generic;
using System.Linq;
using FinalProjectTrelloWebsite.Controllers.Helpers;
using FinalProjectTrelloWebsite.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectTrelloWebsite.Controllers
{
    public class CheckoutController : Controller
    {
        
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.Total = cart.Sum(item => item.Product.price * item.Quantity);

            return View();
        }
    }
}
