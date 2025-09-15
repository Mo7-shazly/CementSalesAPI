using CementSalesAPI_Data.Data;
using CementSalesAPI_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {        
        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IPaymentRepository Payments { get; private set; }
        public IApplicationUserRepository Employees { get; private set; }
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Customers = new CustomerRepository(context);
            Orders = new OrderRepository(context);
            Payments = new PaymentRepository(context);
            Employees = new ApplicationUserRepository(context);
        }


        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
