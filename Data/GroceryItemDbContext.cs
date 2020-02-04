using GroceryTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.Data
{
    public class GroceryTrackerDbContext : DbContext
    {
        public DbSet<GroceryItem> GroceryItems { get; set; }
        public DbSet<GroceryCategory> Categories { get; set; }
        public GroceryTrackerDbContext(DbContextOptions<GroceryTrackerDbContext> options) : base(options)
        {
        }
    }

    
}
