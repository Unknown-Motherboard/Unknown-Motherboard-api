using Microsoft.EntityFrameworkCore;
using Unkown.Motherboard.Domain.Catalog;

namespace Unknown.Motherboard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Item> Items { get; set; }

        public DbSet<Item> Orders {get; set;}
    }
}
