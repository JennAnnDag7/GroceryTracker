using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryTracker.Data;
using GroceryTracker.Models;
using GroceryTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroceryTracker.Controllers
{
    public class GroceryItemController : Controller
    {
        private readonly GroceryTrackerDbContext context;

        public GroceryItemController(GroceryTrackerDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<GroceryItem> groceryitems = context.GroceryItems.ToList();
            
            return View(groceryitems);
        }
        public IActionResult Add()
        {
            AddGroceryItemViewModel addGroceryItemViewModel = new AddGroceryItemViewModel(context.Categories.ToList());
            return View(addGroceryItemViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddGroceryItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                GroceryCategory newGroceryCategory = 
                    context.Categories.Single(c => c.CategoryName == model.CategoryName);
                
                GroceryItem newGroceryItem = new GroceryItem
                {
                    Name = model.Name,
                    
                };

                context.GroceryItems.Add(newGroceryItem);
                context.SaveChanges();

                return Redirect("/GroceryItem");
            }

            return View(model);
        }
    }
}