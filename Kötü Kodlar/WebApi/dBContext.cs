using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class dBCOntext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Cars;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Users { get; set; }
    }
}
