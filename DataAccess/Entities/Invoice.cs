using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entities
{
    public class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal NetTotal { get; set; }
        public decimal Total { get; set; }
        public decimal BalanceDue {get;set;}
        public PaymentData Payment { get; set; }
        public bool Paid { get; set; }
        public ICollection<Resource> Items { get; set; }

    }
}
