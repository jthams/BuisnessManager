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
    public class WorkdayRepo : IWorkdayRepo
    {
        private readonly AdministrationDbContext _context;

        public WorkdayRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }

        public IQueryable<Workday> Workdays { get { return _context.Workdays; } }
        
        public async Task<Workday> FindAsync(int? Id)
        {
            return await _context.Workdays.FindAsync(Id);
        }

        public void Add(Workday workday)
        {
            _context.Add(workday);
            _context.SaveChanges();
        }

        public void Update(Workday workday)
        {
            _context.Update(workday);
            _context.SaveChanges();
        }

        public void Remove(Workday workday)
        {
            _context.Workdays.Remove(workday);
            _context.SaveChanges();
        }
    }
}
