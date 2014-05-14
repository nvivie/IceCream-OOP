using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public class Sundae : IceCream
    {
        public Sundae() { this.Price = base.Price; }
    }
}
