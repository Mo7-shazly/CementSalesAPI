using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Precision(18, 2)]
        public decimal? PricePerTonNorm { get; set; } = 0;
        public int? AmountNorm { get; set; } = 0;
        [Precision(18, 2)]
        public decimal? PricePerTonResistant { get; set; } = 0;
        public int? AmountResistant { get; set; } = 0;
        public string CementType { get; set; }
        [Precision(18, 2)]
        public decimal? AdvancePayment { get; set; }
        [Precision(18, 2)]
        public decimal Total { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}