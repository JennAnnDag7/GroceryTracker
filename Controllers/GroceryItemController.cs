using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroceryTracker.Controllers
{
    public class GroceryItemController : Controller
    {
        private readonly GroceryItemDbContext context;

        public GroceryItemController(GroceryItemDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}