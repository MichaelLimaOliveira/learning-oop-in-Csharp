using Capitulo8.Exemplo.Enum.Entities;
using Capitulo8.Exemplo.Enum.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status =  OrderStatus.PedingPayment

};

Console.WriteLine(order);

var txt = OrderStatus.PedingPayment.ToString();

Console.WriteLine(txt);

var os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
8