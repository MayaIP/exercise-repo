using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_X
{
    class p1_X
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var spaceCenterUp = n - 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}x{1}x{2}", new string(' ', i), 
                    new string(' ', spaceCenterUp), new string(' ', i));
                spaceCenterUp -= 2;
            }

            Console.WriteLine(new string(' ', n/2) + "x" + new string(' ', n / 2));

            var spaceCenterDown = 1;
            for (int i = n/2-1; i >= 0; i--)
            {
                Console.WriteLine("{0}x{1}x{2}", new string(' ', i),
                    new string(' ', spaceCenterDown), new string(' ', i));
                spaceCenterDown += 2;
            }
        }
    }
}
