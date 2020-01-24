using GroceryTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryTracker.Data
{
    public class GroceryItemDbContext : DbContext
    {
        public DbSet<GroceryItem> GroceryItems { get; set; }
        public DbSet<GroceryCategory> Categories { get; set; }
        public GroceryItemDbContext(DbContextOptions<GroceryItemDbContext> options)
            : base(options)
        { }
    }

    
}
