using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAngularWebAPI.Models
{
    public class PaymentdetailsContext:DbContext
    {
        public PaymentdetailsContext(DbContextOptions<PaymentdetailsContext> options):base(options) 
        {
        
        }
        public DbSet<PaymentDetails> paymentDetails { get; set; }
    }
}
