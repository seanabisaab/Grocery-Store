using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Grocery
    {
        Bread my_bread;
        Milk my_milk;
        Eggs my_eggs;

        public Grocery()
        {
            my_eggs = new Eggs(0);
            my_milk = new Milk(0);
            my_bread = new Bread(0);
        }
        public Grocery(Bread b, Milk m, Eggs e)
        {
            my_bread = b;
            my_milk = m;
            my_eggs = e;
        }
        public double expense(Bread my_bread, Milk my_milk, Eggs my_eggs)
        {
            return my_bread.total_price(my_bread.getQ()) + my_milk.total_price(my_milk.getQ()) + my_eggs.total_price(my_eggs.getQ());
        }
        
        public void GroceryInfo()
        {
            Console.WriteLine("Total Amount Due: ${0}", expense(my_bread, my_milk, my_eggs).ToString("0.00"));
        }
    }
}
