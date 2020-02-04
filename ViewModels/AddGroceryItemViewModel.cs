using GroceryTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.ViewModels
{
    public class AddGroceryItemViewModel
    {
        [Required]
        [Display(Name = "Grocery Item Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Expiration { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public List<SelectListItem> GroceryCategories { get; set; }

        
        public AddGroceryItemViewModel(IEnumerable<GroceryCategory> categories)
        {
           GroceryCategories = new List<SelectListItem>();

            foreach (var category in categories)
            {
                GroceryCategories.Add(new SelectListItem()
                {
                    Value = category.ID.ToString(),
                    Text = category.CategoryName
                });
            }
            this.GroceryCategories = GroceryCategories;
        }

        public AddGroceryItemViewModel()
        {
        }
    }
}
