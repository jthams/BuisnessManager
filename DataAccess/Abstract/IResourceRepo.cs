using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IResourceRepo
    {
        IQueryable<Resource> Resources { get; }
        Task<Resource> FindAsync(int? Id);
        void Add(Resource Resource);
        void Update(Resource Resource);
        void Remove(Resource Resources);
    }
}
