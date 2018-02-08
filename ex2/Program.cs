using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaidWithCard cardPayment = new PaidWithCard(100.00F,"0100-0200");
            PaidWithCard cardPayment2 = new PaidWithCard(150.00F, "0200-0300");
            PaidWithCash cashPayment = new PaidWithCash(21.50F);
            PaidWithCash cashPayment2 = new PaidWithCash(5.20F);
            Console.WriteLine(cardPayment.ShowTransaction());
            Console.WriteLine(cardPayment2.ShowTransaction());
            Console.WriteLine("Transaction total: {0}", cardPayment.GetAmount() + cardPayment2.GetAmount());
            Console.WriteLine(cashPayment.ShowTransaction());
            Console.WriteLine(cashPayment2.ShowTransaction());

            Console.WriteLine("Cash in the register: {0}", cashPayment.ShowCash());
            Console.ReadKey(true);
        }
    }
}
