using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order(int i, DateTime d, List<OrderItem> oi)
        {
            ID = i;
            Date = d;
            OrderItems = oi;
        }
    }
}
