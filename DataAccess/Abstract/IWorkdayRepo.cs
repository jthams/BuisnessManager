using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IWorkdayRepo
    {
        IQueryable<Workday> Workdays { get; }
        Task<Workday> FindAsync(int? Id);
        void Add(Workday Workday);
        void Update(Workday Workday);
        void Remove(Workday Workday);
    }
}
