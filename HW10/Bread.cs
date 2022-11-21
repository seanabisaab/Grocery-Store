using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Bread
    {
        private const double price = 2.50 ;
        private int quantity;

        public Bread()
        {
            quantity = 0;
        }

        public int getQ() //Accessor
        {
            return this.quantity;
        }

        public Bread(int q)
        {
            quantity = q;
        }
        
        public double total_price(int q)
        {
            return price *q;
        }

        public void ObjectInfo()
        {
            Console.WriteLine("Item: {0}", "Bread");
            Console.WriteLine("Price: {0}", price.ToString("0.00"));
            Console.WriteLine("Quantity: {0}", getQ());
            Console.WriteLine("Total Price: ${0}", total_price(quantity).ToString("0.00"));
            Console.WriteLine();

        }



    }
}
