using CementSalesAPI_Data.Data;
using CementSalesAPI_Data.Repositories;
using CementSalesAPI_Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Implementation
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
