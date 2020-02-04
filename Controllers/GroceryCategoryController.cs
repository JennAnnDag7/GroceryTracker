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
    public class GroceryCategoryController : Controller
    {

        private readonly GroceryTrackerDbContext context;

        public GroceryCategoryController(GroceryTrackerDbContext dbContext)
        {
            context = dbContext;
        }



        public IActionResult Index()
        {
            List<GroceryCategory> categories = context.Categories.ToList();

            return View(categories);
        }
        public IActionResult Add()
        {
            AddGroceryCategoryViewModel addGroceryCategoryViewModel = new AddGroceryCategoryViewModel();
            return View(addGroceryCategoryViewModel);

        }
        [HttpPost]
        public IActionResult Add(AddGroceryCategoryViewModel addGroceryCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new category to my existing categories
                GroceryCategory newGroceryCategory = new GroceryCategory
                {
                    CategoryName = addGroceryCategoryViewModel.CategoryName,
                };

                context.Categories.Add(newGroceryCategory);
                context.SaveChanges();

                return Redirect("/GroceryCategory");
            }

            return View(addGroceryCategoryViewModel);
        }

        public IActionResult Remove()
        {
            List<GroceryCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Remove(int[] categoryIds)
        {
            foreach (int categoryId in categoryIds)
            {
                GroceryCategory theCategory = context.Categories.Single(c => c.ID == categoryId);
                context.Categories.Remove(theCategory);
            }
            context.SaveChanges();
            return Redirect("/GroceryCategory");
        }
    }
}
    

