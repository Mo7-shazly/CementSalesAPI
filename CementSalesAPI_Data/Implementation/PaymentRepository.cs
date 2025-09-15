using CementSalesAPI_Data.Data;
using CementSalesAPI_Data.Repositories;
using CementSalesAPI_Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Implementation
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly ApplicationDbContext _context;
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<decimal> Sum(Expression<Func<Payment, decimal>> selector)
        {
            return await _context.Set<Payment>().SumAsync(selector);
        }
    }
}
