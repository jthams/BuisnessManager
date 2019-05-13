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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>().ToTable("Clients");
            builder.Entity<Employee>().ToTable("Employeess");
            builder.Entity<Invoice>().ToTable("Invoices");
            builder.Entity<PaymentData>().ToTable("Payment Data");
            builder.Entity<Project>().ToTable("Projects");

        }
    }
}
