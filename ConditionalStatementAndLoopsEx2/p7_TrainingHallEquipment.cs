using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7_TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());

            var subtotal = 0.0;
            for (int i = 0; i < num; i++)
            {
                var name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var count = int.Parse(Console.ReadLine());
                if (count > 1)
                {
                    name += "s";
                }
                Console.WriteLine($"Adding {count} {name} to cart.");

                subtotal += price * count;  
            }
            var diff = budget - subtotal;
            if (diff >= 0)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${diff:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${Math.Abs(diff):F2} more.");
            }
        }
    }
}
