using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Workday> HoursOfOperation  { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
