using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public decimal Wage { get; set; }
        public int? Salary { get; set; }
        public ICollection<Workday> Availability { get; set; }
        public Organization Employer { get; set; }
        public ICollection<Invoice> PayStubs { get; set; }
    }
}
