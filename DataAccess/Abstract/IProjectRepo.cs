using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Abstract
{
    public interface IProjectRepo
    {
        IQueryable<Project> Projects { get; }
        Task<Project> FindAsync(int? Id);
        void Add(Project Project);
        void Update(Project Project);
        void Remove(Project Project);
    }
}
