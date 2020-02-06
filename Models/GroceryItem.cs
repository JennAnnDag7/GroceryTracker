using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.Models
{
    public class GroceryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Expiration { get; set; }
        
        public GroceryCategory Category { get; set; }
        public int CategoryID { get; set; }


    }
}
