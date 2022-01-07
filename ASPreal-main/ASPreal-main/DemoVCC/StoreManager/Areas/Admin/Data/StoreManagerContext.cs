using Microsoft.EntityFrameworkCore;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.Data
{
    public class StoreManagerContext : DbContext
    {
        public StoreManagerContext(DbContextOptions<StoreManagerContext> options) : base(options)
        { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
