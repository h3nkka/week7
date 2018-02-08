using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class PaidWithCard : ITransaction
    {
        float Amount { get; set; }
        string Card { get; set; }

        public PaidWithCard(float a, string c)
        {
            Amount = a;
            Card = c;
        }
        public string ShowTransaction()
        {
            return "Bank transaction via card number " + Card + " Date: " + DateTime.Now + " Amount: " + Amount;
        }
        public float GetAmount()
        {
            return Amount;
        }

    }
}
