using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }

        public MySqlContext(DbContextOptions options) : base(options) 
        {            
        }

        public DbSet<Products> Products { get; set; }
    }
}
