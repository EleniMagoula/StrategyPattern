using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop
{
    class Cash : IPaymentStrategy
    {
        public int ShippingCosts { get; set; } = 3;

        public int Pay(int shirtCost)
        {
            var finalCost = shirtCost + ShippingCosts;

            if (finalCost >= 25)
                finalCost -= ShippingCosts;

            return finalCost;
        }
    }
}
