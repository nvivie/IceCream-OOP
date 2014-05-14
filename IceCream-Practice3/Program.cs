using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream_Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sundae sundae = new Sundae();
            Scoop s = new Scoop(Flavor.ChocolatChips);
            //sundae.AddScoop(s);
            sundae.AddProduct(s);
            Cherrry c = new Cherrry();
            sundae.AddProduct(c);
            //sundae.AddTopping(c);
            //Console.WriteLine(c.About());
            Console.WriteLine(sundae.About());

            WaffleCone w = new WaffleCone();
            Scoop PeanutButter = new Scoop(Flavor.PeanutButter);
            w.AddProduct(PeanutButter);
            //w.AddScoop(PeanutButter);
            Nuts n = new Nuts();
            //w.AddTopping(n);
            w.AddProduct(n);
            //Console.WriteLine(n.About());
            Console.WriteLine(w.About());

            Console.ReadKey();
            
        }
    }
}
