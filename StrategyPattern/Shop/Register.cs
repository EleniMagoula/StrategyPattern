using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop
{
    class Register
    {
        private IPaymentStrategy _payment;

        public void SetPaymentStrategy(IPaymentStrategy payment) => _payment = payment;

        public void Pay(int shopping_baskset)
        {
            var cost = _payment.Pay(shopping_baskset);
            Console.WriteLine("Cost of the T-Shirt(s): " + cost);
        }
    }
}
