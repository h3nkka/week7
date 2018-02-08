using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string n)
        {
            Name = n;
            Orders = new List<Order>();
        }

        public void ShowOrders()
        {
            Console.WriteLine("Printing orders for customer {0}", Name);
            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine("\nOrder {0}: ({1})",Orders[i].ID,Orders[i].Date);
                for (int p = 0; p < Orders[i].OrderItems.Count; p++)
                {
                    Console.WriteLine("{0} x{1}", Orders[i].OrderItems[p].Name, Orders[i].OrderItems[p].Count);
                }
           }
        }
    }
}
