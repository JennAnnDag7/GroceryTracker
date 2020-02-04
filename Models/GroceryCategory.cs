using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.Models
{
    public class GroceryCategory
    {
        public string CategoryName { get; set; }
        public int ID { get; set; }

        public IList<GroceryItem> GroceryItems { get; set; }
        
    }
}
