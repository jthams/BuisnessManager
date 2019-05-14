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
    public class OrganizationRepo : IOrganizationRepo
    {
        private readonly AdministrationDbContext _context;

        public OrganizationRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Organization> Organizations { get { return _context.Organizations; } }

        public async Task<Organization> FindAsync(int? Id)
        {
            return await _context.Organizations.FindAsync(Id);
        }

        public void Add(Organization Organization)
        {
            _context.Add(Organization);
            _context.SaveChanges();
        }

        public void Update(Organization Organization)
        {
            _context.Update(Organization);
            _context.SaveChanges();
        }

        public void Remove(Organization Organization)
        {
            _context.Organizations.Remove(Organization);
            _context.SaveChanges();
        }
    }
}
