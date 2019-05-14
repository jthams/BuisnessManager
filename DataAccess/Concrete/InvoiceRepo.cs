using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Entities;
using DataAccess.Contexts;

namespace DataAccess.Concrete
{
    public class InvoiceRepo :IInvoiceRepo
    {
        private readonly AdministrationDbContext _context;

        public InvoiceRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Invoice> Invoices { get { return _context.Invoices; } }

        public async Task<Invoice> FindAsync(int? Id)
        {
            return await _context.Invoices.FindAsync(Id);
        }

        public void Add(Invoice Invoice)
        {
            _context.Add(Invoice);
            _context.SaveChanges();
        }

        public void Update(Invoice Invoice)
        {
            _context.Update(Invoice);
            _context.SaveChanges();
        }

        public void Remove(Invoice Invoice)
        {
            _context.Invoices.Remove(Invoice);
            _context.SaveChanges();
        }
    }
}
