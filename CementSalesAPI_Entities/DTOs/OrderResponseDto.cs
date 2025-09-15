using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.DTOs
{
    public class OrderResponseDto
    {
        public int Id { get; set; }
        public string CementType { get; set; }
        public decimal Total { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
    }
}
