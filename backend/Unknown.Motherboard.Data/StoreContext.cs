using Microsoft.EntityFrameworkCore;
using Unknown.Motherboard.Domain.Catalog;

namespace Unknown.Motherboard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Item> Items { get; set; }

    }
}
