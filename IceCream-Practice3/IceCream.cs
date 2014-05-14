using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceCream_Practice3
{
    public abstract class IceCream
    {
        public double Price;
        public List<Scoop> ScoopList;
        public List<Topping> ToppingList;
        public List<IProduct> Products;
        
         //constructors
        public IceCream() {
            this.Price = 0.5;
            this.ScoopList = new List<Scoop>();
            this.ToppingList = new List<Topping>();
            this.Products = new List<IProduct>();
        }
        public string About()
        {
            string about = "";
            // loop through each scoopList
            about += string.Format("IceCream: {0}  ${1}", this.ToString(), this.Price);
            foreach(IProduct p in Products)
            {
                about += string.Format("\nProduct: {0}  ${1}", p.Name, p.Price);
            }
            about += "\nYOUR TOTAL:  $" + this.GetPrice();
            return about;
        }

        public void AddScoop(Scoop s) // watch out constructor this.ScoopList = new List<Scoop>();
        {
            ScoopList.Add(s);
        }

        public void AddTopping(Topping t)
        {
            ToppingList.Add(t);
        }

        public void AddProduct(IProduct product) {
            Products.Add(product);
        }

        public double GetPrice()
        {
            double total = this.Price;// price of icecream cones
            foreach (IProduct p in Products) {
                total += p.Price;
            }
            /*foreach(Scoop s in ScoopList){
                total += s.Price;
            }
            foreach(Topping t in ToppingList){
                total += t.Price;
            }*/
            return total;
        }
    }
}
