using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string? Way { get; set; }
        public decimal Paid { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
