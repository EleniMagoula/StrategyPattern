using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Shop.Create_TShirt
{
    class TShirt
    {
        public Color Color { get; set; }

        public Size Size { get; set; }

        public Fabric Fabric { get; set; }

        private int _cost;
        public int Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = (int)Color + (int)Size + (int)Fabric;
            }
        }
    }
}
