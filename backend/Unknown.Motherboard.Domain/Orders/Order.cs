using System.Collections.Generic;
using System.Linq;

namespace Unknown.Motherboard.Domain.Orders
{
    public class Order
    {
        public int Id {get; set;}
        public List<OrderItem> Items {get; set;}
        public decimal TotalPrice => Items.Sum(i => i.Price);
    }
}