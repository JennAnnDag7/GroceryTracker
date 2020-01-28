using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryTracker.Data;
using GroceryTracker.Models;
using GroceryTracker.ViewModels;
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
            List<GroceryItem> groceryitems;
            groceryitems = context.GroceryItems.ToList();
            return View(groceryitems);
        }
        public IActionResult Add()
        {
            AddGroceryItemViewModel addGroceryItemViewModel = new AddGroceryItemViewModel();
            return View(addGroceryItemViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddGroceryItemViewModel addGroceryItemViewModel)
        {
            if (ModelState.IsValid)
            {
                
                GroceryItem newGroceryItem = new GroceryItem
                {
                    Name = addGroceryItemViewModel.Name,
                };

                context.GroceryItems.Add(newGroceryItem);
                context.SaveChanges();

                return Redirect("/GroceryItem");
            }

            return View(addGroceryItemViewModel);
        }
    }
}