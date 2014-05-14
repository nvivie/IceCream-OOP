using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public interface IProduct
    {
        string Name
        {
            get;
            set;
        }

        double Price
        {
            get;
            set;
        }
    }
}
