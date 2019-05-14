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
    public class ClientRepo : IClientRepo
    {
        private readonly AdministrationDbContext _context;

        public ClientRepo(AdministrationDbContext Context)
        {
            _context = Context;
        }
        public IQueryable<Client> Clients { get { return _context.Clients; } }

        public async Task<Client> FindAsync(int? Id)
        {
            return await _context.Clients.FindAsync(Id);
        }

        public void Add(Client Client)
        {
            _context.Add(Client);
            _context.SaveChanges();
        }

        public void Update(Client Client)
        {
            _context.Update(Client);
            _context.SaveChanges();
        }

        public void Remove(Client Client)
        {
            _context.Clients.Remove(Client);
            _context.SaveChanges();
        }
    }
}
