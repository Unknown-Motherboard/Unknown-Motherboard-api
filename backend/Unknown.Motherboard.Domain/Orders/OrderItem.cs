using Unkown.Motherboard.Domain.Catalog;

namespace Unkown.Motherboard.Domain.Orders
{
    public class OrderItem
    {
        public int Id {get; set;}
        public int Item {get; set;}
        public int Quantity {get; set;}
        public int Price => Item.Price * Quantity;
    }
}