using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Eggs
    {
        private const double price = 4.00;
        private int quantity;

        public Eggs()
        {
            quantity = 0;
        }
        
        public int getQ() //Accessor
        {
            return this.quantity;
        }

        public Eggs(int q)
        {
            quantity = q;
        }

        public double total_price(int q)
        {
            return price * q;
        }

        public void ObjectInfo()
        {
            Console.WriteLine("Item: {0}", "Eggs");
            Console.WriteLine("Price: {0}", price.ToString("0.00"));
            Console.WriteLine("Quantity: {0}", getQ());
            Console.WriteLine("Total Price: ${0}", total_price(quantity).ToString("0.00"));
            Console.WriteLine();

        }

    }
}
