using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public class WaffleCone : IceCream
    {
        public WaffleCone() { this.Price = base.Price + 0.5; }
    }
}
