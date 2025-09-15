using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.DTOs
{
    public class CustomerStatementDto
    {
        public string CustomerName { get; set; }
        public string Location { get; set; }

        public List<CustomerStatementEntryDto> Entries { get; set; } = new();

        public decimal TotalSales => Entries.Sum(e => e.Sales);
        public decimal TotalPayments => Entries.Sum(e => e.Payments);
        public decimal FinalBalance => Entries.LastOrDefault()?.Balance ?? 0;
    }

}
