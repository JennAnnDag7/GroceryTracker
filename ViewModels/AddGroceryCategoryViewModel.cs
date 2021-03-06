﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.ViewModels
{
    public class AddGroceryCategoryViewModel
    {
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
