using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.DTOs
{
    public class OrderDto
    {
        [Precision(18, 2)]
        public decimal? PricePerTonNorm { get; set; } = 0;
        public int? AmountNorm { get; set; } = 0;
        [Precision(18, 2)]  
        public decimal? PricePerTonResistant { get; set; } = 0;
        public int? AmountResistant { get; set; } = 0;
        public string CementType { get; set; }
        [Precision(18, 2)]
        public decimal? AdvancePayment { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
    }
}
