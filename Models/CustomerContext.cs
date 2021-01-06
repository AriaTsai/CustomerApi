using Microsoft.EntityFrameworkCore;
//using CustomerApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace CustomerApi.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base (options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
    }
    public class LongDateTimeConvert : IsoDateTimeConverter
    {
        public LongDateTimeConvert() : base()
        {
            base.DateTimeFormat = "yyyy/MM/dd";
        }
    }

}
 