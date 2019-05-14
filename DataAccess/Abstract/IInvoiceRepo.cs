using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IInvoiceRepo
    {
        IQueryable<Invoice> Invoices { get; }
        Task<Invoice> FindAsync(int? Id);
        void Add(Invoice Invoice);
        void Update(Invoice Invoice);
        void Remove(Invoice Invoice);
    }
}
