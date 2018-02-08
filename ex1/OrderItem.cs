using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class OrderItem
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public OrderItem(string n, int c)
        {
            Name = n;
            Count = c;
        }
    }
}
