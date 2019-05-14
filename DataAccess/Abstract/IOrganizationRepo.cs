using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IOrganizationRepo
    {
        IQueryable<Organization> Organizations { get; }
        Task<Organization> FindAsync(int? Id);
        void Add(Organization Organization);
        void Update(Organization Organization);
        void Remove(Organization Organization);
    }
}
