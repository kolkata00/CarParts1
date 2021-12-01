using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class PartsDBContext : DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Articles { get; set; }
       
        public DbSet<Comment> Comments { get; set; }
    }
}