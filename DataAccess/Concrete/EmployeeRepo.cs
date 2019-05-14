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
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AdministrationDbContext _context;

        public EmployeeRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Employee> Employees { get { return _context.Employees; } }

        public async Task<Employee> FindAsync(int? Id)
        {
            return await _context.Employees.FindAsync(Id);
        }

        public void Add(Employee Employee)
        {
            _context.Add(Employee);
            _context.SaveChanges();
        }

        public void Update(Employee Employee)
        {
            _context.Update(Employee);
            _context.SaveChanges();
        }

        public void Remove(Employee Employee)
        {
            _context.Employees.Remove(Employee);
            _context.SaveChanges();
        }
    }
}
