using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public abstract class Topping : IProduct
    {
        //public string Name;
        //public double Price;

        //properties
        public string Name
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public Topping(){}
        public string About()
        {
            string about = "";
            about += string.Format("\nTopping: {0} ${1}", this.Name, this.Price);
            return about;
        }

    }
}
