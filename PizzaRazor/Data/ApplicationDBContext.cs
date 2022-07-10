using Microsoft.EntityFrameworkCore;
using PizzaRazor.Models;


namespace PizzaRazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        // one table with all the pizza orders rgiht now
        public DbSet<PizzaOrder> PizzaOrders {get; set;}
        // make a constructor 
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options )
            : base(options)
        {

        }
    }
}
