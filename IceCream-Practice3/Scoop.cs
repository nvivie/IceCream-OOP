using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public class Scoop : IProduct
    {
        //public Flavor flavor;
        //public double Price;
        // these are properties, have get and set. It's like fields
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

        //constructor1
        public Scoop() { this.Price = 0.5; }
        //constructor2
        public Scoop(Flavor f) { 
            this.Flavor = f; 
            this.Price = 0.5;
            this.Name = f.ToString();
        } // this.Flavor is name of association arrow

        public Flavor Flavor
        {
            // the 1st Flavor is enum name
            //The 2nd Flavor is the name on the arrow association
            get;
            set;
        }
      
    }
}
