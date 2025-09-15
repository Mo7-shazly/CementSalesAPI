using Microsoft.EntityFrameworkCore;

namespace CementSalesAPI_Entities.DTOs
{
    public class CustomerStatementEntryDto
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public decimal QuantityNorm { get; set; }
        public decimal PricePerTonNorm { get; set; }

        public decimal QuantityResistant { get; set; }
        public decimal PricePerTonResistant { get; set; }
        public decimal AdvancePayment { get; set; } = 0;
        public decimal Quantity => QuantityNorm + QuantityResistant;

        public decimal Sales { get; set; }
        public decimal Payments { get; set; }
        public decimal Balance { get; set; }
        public int TransactionType { get; set; }
    }
}
