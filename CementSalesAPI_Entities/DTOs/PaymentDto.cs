using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.DTOs
{
    public class PaymentDto
    {
        public string? Way { get; set; }
        public decimal Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CustomerId { get; set; }
    }
}
