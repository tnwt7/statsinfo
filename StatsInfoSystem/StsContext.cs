﻿using System.Data.Entity;

namespace StatsInfoSystem
{
    public class StsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<CustomerArea> CustomerAreas { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleLine> SaleLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
