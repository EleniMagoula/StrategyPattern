using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop
{
    public interface IPaymentStrategy
    {
        int ShippingCosts { get; set; }

        int Pay(int shirtCost);
    }
}
