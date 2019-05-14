using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DataAccess.Entities;

namespace DataAccess.Contexts
{
    public class AdministrationDbContext : DbContext
    {
        public AdministrationDbContext(DbContextOptions<AdministrationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PaymentData> PaymentData { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Workday> Workdays { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>().ToTable("Clients");
            builder.Entity<Employee>().ToTable("Employeess");
            builder.Entity<Invoice>().ToTable("Invoices");
            builder.Entity<PaymentData>().ToTable("Payment Data");
            builder.Entity<Project>().ToTable("Projects");
            builder.Entity<Workday>().ToTable("Workdays");
            builder.Entity<Organization>().ToTable("Organizations");
            builder.Entity<Resource>().ToTable("Resources");

        }
    }
}
