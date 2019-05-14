using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Entities;
using DataAccess.Contexts;

namespace DataAccess.Abstract
{
    public class PaymentDataRepo : IPaymentDataRepo
    {
        private readonly AdministrationDbContext _context;

        public PaymentDataRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<PaymentData> PaymentData { get { return _context.PaymentData; } }

        public async Task<PaymentData> FindAsync(int? Id)
        {
            return await _context.PaymentData.FindAsync(Id);
        }

        public void Add(PaymentData PaymentData)
        {
            _context.Add(PaymentData);
            _context.SaveChanges();
        }

        public void Update(PaymentData PaymentData)
        {
            _context.Update(PaymentData);
            _context.SaveChanges();
        }

        public void Remove(PaymentData PaymentData)
        {
            _context.PaymentData.Remove(PaymentData);
            _context.SaveChanges();
        }
    }
}
