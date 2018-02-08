using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class PaidWithCash : ITransaction
    {
        float Amount { get; set; }
        static float Cash { get; set; }
        public PaidWithCash(float a)
        {
            Amount = a;
            Cash += a;
        }
        public string ShowTransaction()
        {
            return "Paid with cash. Date: " + DateTime.Now + " Amount: " + Amount;
        }
        public float GetAmount()
        {
            return Amount;
        }
        public float ShowCash()
        {
            return Cash;
        }
    }
}
