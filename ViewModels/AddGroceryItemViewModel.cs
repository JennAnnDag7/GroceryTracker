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

        [Required(ErrorMessage = "You must enter an expiration date")]
        public string Expiration { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddGroceryItemViewModel()
        {
        }

        public AddGroceryItemViewModel(List<GroceryCategory> categories)
        {
            //this.Categories = categories;
            //CheeseTypes = new List<SelectListItem>();
            // <option value="0">Hard</option>

            Categories = new List<SelectListItem>();

            foreach (GroceryCategory category in categories)
            {
                Categories.Add(new SelectListItem()
                {
                    Value = category.ID.ToString(),
                    Text = category.Name
                });
            }
        }
    }
}
