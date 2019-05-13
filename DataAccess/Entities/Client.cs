using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Entities
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public ICollection<PaymentData> PaymentData { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
