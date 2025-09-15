using CementSalesAPI_Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Data.Repositories
{
    public interface IPaymentRepository:IGenericRepository<Payment>
    {
        Task<decimal> Sum(Expression<Func<Payment, decimal>> selector);
    }
}
