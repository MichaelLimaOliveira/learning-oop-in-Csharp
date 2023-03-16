using Capitulo8.Exercicio.Proposto1.Enum.Entities.Enums;

namespace Capitulo8.Exercicio.Proposto1.Enum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, List<OrderItem> items, Client client)
        {
            Moment = moment;
            Status = status;
            Items = items;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            var test = Items.Where<OrderItem>(e => e.Quantity <= 3);

            return sum;

        }
    }
}
