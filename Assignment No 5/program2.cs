using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No_5
{
    public class program2
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.GetData(1, "HP Laptop", 45000, 15);
            p.Calculate();
            Console.WriteLine(p.display());

            Product p2 = new Product();
            p2.GetData(2, "Lenvo Laptop", 40000, 20);
            p2.Calculate();
            Console.WriteLine(p2.display());

            Product p3 = new Product();
            p3.GetData(3, "Dell Laptop", 50000, 25);
            p3.Calculate();
            Console.WriteLine(p3.display());
        }
    }
}
