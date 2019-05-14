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
    public class ResourceRepo : IResourceRepo
    {
        private readonly AdministrationDbContext _context;

        public ResourceRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Resource> Resources { get { return _context.Resources; } }

        public async Task<Resource> FindAsync(int? Id)
        {
            return await _context.Resources.FindAsync(Id);
        }

        public void Add(Resource Resource)
        {
            _context.Add(Resource);
            _context.SaveChanges();
        }

        public void Update(Resource Resource)
        {
            _context.Update(Resource);
            _context.SaveChanges();
        }

        public void Remove(Resource Resource)
        {
            _context.Resources.Remove(Resource);
            _context.SaveChanges();
        }
    }
}
