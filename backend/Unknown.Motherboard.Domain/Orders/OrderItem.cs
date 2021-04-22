using Unkown.Motherboard.Domain.Catalog;

namespace Unkown.Motherboard.Domain.Orders
{
    public class OrderItem
    {
        public int Id {get; set;}
        public Item Item {get; set;}
        public int Quantity {get; set;}
        public decimal Price => Item.Price * Quantity;
    }
}