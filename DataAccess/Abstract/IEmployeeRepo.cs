using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IEmployeeRepo
    {
        IQueryable<Employee> Employees { get; }
        Task<Employee> FindAsync(int? Id);
        void Add(Employee Employee);
        void Update(Employee Employee);
        void Remove(Employee Employee);
    }
}
