using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IClientRepo
    {
        IQueryable<Client> Clients { get; }
        Task<Client> FindAsync(int? Id);
        void Add(Client Client);
        void Update(Client Client);
        void Remove(Client Client);
    }
}
