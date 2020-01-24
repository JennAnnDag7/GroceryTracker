using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryTracker.Data;
using GroceryTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryTracker.Controllers
{
    public class GroceryCategoryController : Controller
    {

        private readonly GroceryItemDbContext context;

        public GroceryCategoryController(GroceryItemDbContext dbContext)
        {
            context = dbContext;
        }



        public IActionResult Index()
        {
            List<GroceryCategory> categories = context.Categories.ToList();

            return View(categories);
        }
    }
}