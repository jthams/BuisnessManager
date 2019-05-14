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
    public class ProjectRepo : IProjectRepo
    {
        private readonly AdministrationDbContext _context;

        public ProjectRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Project> Projects { get { return _context.Projects; } }

        public async Task<Project> FindAsync(int? Id)
        {
            return await _context.Projects.FindAsync(Id);
        }

        public void Add(Project Project)
        {
            _context.Add(Project);
            _context.SaveChanges();
        }

        public void Update(Project Project)
        {
            _context.Update(Project);
            _context.SaveChanges();
        }

        public void Remove(Project Project)
        {
            _context.Projects.Remove(Project);
            _context.SaveChanges();
        }
    }
}
