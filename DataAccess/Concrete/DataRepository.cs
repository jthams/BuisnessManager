using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Entities;
using DataAccess.Contexts;

namespace DataAccess.Concrete
{
    public class DataRepository : IDataRepository
    {
        private readonly AdministrationDbContext _context;
        public DataRepository(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Client> Clients { get { return _context.Clients; }  }
        public IQueryable<Employee> Employees { get { return _context.Employees; } }
        public IQueryable<Organization> Organizations { get { return _context.Organizations; } }
        public IQueryable<Resource> Resources { get { return _context.Resources; } }
        public IQueryable<Invoice> Invoices { get { return _context.Invoices; } }
        public IQueryable<Workday> Workdays { get { return _context.Workdays; } }
        public IQueryable<PaymentData> PaymentData { get { return _context.PaymentData; } }
        public IQueryable<Project> Projects { get { return _context.Projects; } }
    }
}
