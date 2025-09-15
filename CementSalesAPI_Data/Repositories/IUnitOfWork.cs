using CementSalesAPI_Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IPaymentRepository Payments { get; }
        IApplicationUserRepository Employees { get; }
        Task<int> Complete();
    }
}
