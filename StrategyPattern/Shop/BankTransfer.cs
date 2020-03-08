using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop
{
    class BankTransfer : IPaymentStrategy
    {
        public int ShippingCosts { get; set; } = 0;

        public int Pay(int shirtCost)
        {
            var finalCost = shirtCost + ShippingCosts;

            if (finalCost >= 35)
                finalCost -= 3;

            return finalCost;
        }
    }
}
