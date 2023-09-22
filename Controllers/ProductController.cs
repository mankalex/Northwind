using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        // this controller depends on the DataContext
        private DataContext _dataContext;
        public ProductController(DataContext db) => _dataContext = db;

        public IActionResult Category() => View(_dataContext.Categories);
    }
}