using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Budget { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
