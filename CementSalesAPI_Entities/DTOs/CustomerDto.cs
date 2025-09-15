using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CementSalesAPI_Entities.DTOs
{
    public class CustomerDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Address { get; set; }
        [Required, MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string? PhoneNo1 { get; set; }
        [MaxLength(100)]
        public string? PhoneNo2 { get; set; }
    }
}
