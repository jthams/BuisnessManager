using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IDataRepository
    {
        IQueryable<Client> Clients { get; }
        IQueryable<Employee> Employees { get; }
        IQueryable<Organization> Organizations { get; }
        IQueryable<Resource> Resources { get; }
        IQueryable<Invoice> Invoices { get; }
        IQueryable<Workday> Workdays { get; }
        IQueryable<PaymentData> PaymentData { get; }
        IQueryable<Project> Projects { get; }
    }
}
