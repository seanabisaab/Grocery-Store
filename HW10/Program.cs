using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much bread do you want.");
            int bq = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How much milk do you want.");
            int mq = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many Eggs do you want.");
            int eq = Int32.Parse(Console.ReadLine());
            Bread b = new Bread(bq);
            Milk m = new Milk(mq);
            Eggs e = new Eggs(eq);
            Grocery g = new Grocery(b, m, e);
            b.ObjectInfo();
            m.ObjectInfo();
            e.ObjectInfo();
            g.GroceryInfo();
        }
    }
}
