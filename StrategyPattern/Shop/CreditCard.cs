using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop
{
    class CreditCard : IPaymentStrategy
    {
        public int ShippingCosts { get; set; } = 0;

        public int Pay(int shirtCost)
        {
            var finalCost = shirtCost + ShippingCosts;

            return finalCost;
        }
    }
}
