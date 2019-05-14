using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IPaymentDataRepo
    {
        IQueryable<PaymentData> PaymentData { get; }
        Task<PaymentData> FindAsync(int? Id);
        void Add(PaymentData PaymentData);
        void Update(PaymentData PaymentData);
        void Remove(PaymentData PaymentData);
    }
}
