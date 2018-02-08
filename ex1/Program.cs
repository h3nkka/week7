using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer henri = new Customer("Henri");
            OrderItem kalja = new OrderItem("Kalja", 50);
            OrderItem sausage = new OrderItem("Sausage", 5);
            Order order1 = new Order(1, DateTime.Now, new List<OrderItem>() { kalja, sausage });

            OrderItem tv = new OrderItem("TV", 1);
            OrderItem batteries = new OrderItem("Batteries", 8);
            Order order2 = new Order(2, DateTime.MaxValue, new List<OrderItem>() { tv, batteries });

            henri.Orders = new List<Order>() { order1, order2 };
            henri.ShowOrders();
            Console.ReadKey(true);
        }
    }
}
