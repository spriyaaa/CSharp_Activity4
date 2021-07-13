using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity4BL;

namespace Activity4UI
{
    class Program
    {
        Purchase p = new Purchase();

        static void Main(string[] args)
        {
            /* string customer = Console.ReadLine(); //params
             for (int i = 0; i < Product product.Length; i++)
             {
                 Console.Read(Product[i] + " ");
             }
             */

            DateTime dt1 = new DateTime(2000, 01, 02);
            Purchase p = new Purchase("simran",20, "Patna", dt1, "online");
            Product pr = new Product("natraj" ,"used for writing", 5, Category.Pencil);
            Console.WriteLine(p.CalculateBillAmount(pr, 10));



        }

    }
}
