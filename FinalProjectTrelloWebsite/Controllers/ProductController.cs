using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectTrelloWebsite.Models;
using Microsoft.AspNetCore.Mvc;



namespace FinalProjectTrelloWebsite.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

    }
}
