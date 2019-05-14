﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AdministrationDbContext))]
    [Migration("20190514170724_added_Entities")]
    partial class added_Entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DataAccess.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<int?>("EmployerId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("ProjectId");

                    b.Property<int?>("Salary");

                    b.Property<string>("StreetAddress");

                    b.Property<decimal>("Wage");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Employeess");
                });

            modelBuilder.Entity("DataAccess.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BalanceDue");

                    b.Property<int?>("ClientId");

                    b.Property<int?>("EmployeeId");

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<decimal>("NetTotal");

                    b.Property<bool>("Paid");

                    b.Property<int?>("PaymentId");

                    b.Property<int?>("ProjectId");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DataAccess.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("DataAccess.Entities.PaymentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName");

                    b.Property<int>("AccountNumber");

                    b.Property<string>("AccountType");

                    b.Property<int?>("ClientId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Payment Data");
                });

            modelBuilder.Entity("DataAccess.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<int?>("ClientId");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DataAccess.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("InvoiceId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("DataAccess.Entities.Workday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day");

                    b.Property<int?>("EmployeeId");

                    b.Property<int>("EndTime");

                    b.Property<int?>("OrganizationId");

                    b.Property<int>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Workdays");
                });

            modelBuilder.Entity("DataAccess.Entities.Client", b =>
                {
                    b.HasOne("DataAccess.Entities.Organization")
                        .WithMany("Clients")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DataAccess.Entities.Employee", b =>
                {
                    b.HasOne("DataAccess.Entities.Organization", "Employer")
                        .WithMany("Employees")
                        .HasForeignKey("EmployerId");

                    b.HasOne("DataAccess.Entities.Project")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("DataAccess.Entities.Invoice", b =>
                {
                    b.HasOne("DataAccess.Entities.Client")
                        .WithMany("Invoices")
                        .HasForeignKey("ClientId");

                    b.HasOne("DataAccess.Entities.Employee")
                        .WithMany("PayStubs")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("DataAccess.Entities.PaymentData", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("DataAccess.Entities.Project")
                        .WithMany("Invoices")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("DataAccess.Entities.PaymentData", b =>
                {
                    b.HasOne("DataAccess.Entities.Client")
                        .WithMany("PaymentData")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("DataAccess.Entities.Project", b =>
                {
                    b.HasOne("DataAccess.Entities.Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId");

                    b.HasOne("DataAccess.Entities.Organization")
                        .WithMany("Projects")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("DataAccess.Entities.Resource", b =>
                {
                    b.HasOne("DataAccess.Entities.Invoice")
                        .WithMany("Items")
                        .HasForeignKey("InvoiceId");
                });

            modelBuilder.Entity("DataAccess.Entities.Workday", b =>
                {
                    b.HasOne("DataAccess.Entities.Employee")
                        .WithMany("Availability")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("DataAccess.Entities.Organization")
                        .WithMany("HoursOfOperation")
                        .HasForeignKey("OrganizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
