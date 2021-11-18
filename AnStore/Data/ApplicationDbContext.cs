using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AnStore.Models;

namespace AnStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Operation> Operations { get; set; }       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }


}
