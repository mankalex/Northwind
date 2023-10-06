using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        // this controller depends on the DataContext
        private DataContext _dataContext;
        public ProductController(DataContext db) => _dataContext = db;

        public IActionResult Category() => View(_dataContext.Categories.OrderBy(b => b.CategoryName));

        public IActionResult Discount() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now));

        public IActionResult Index(int id)
        {
            // ViewBag.CategoryId = id;
            return View(_dataContext.Products.Where(p => p.CategoryId == id && !p.Discontinued));
        }

    }
}