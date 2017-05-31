using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var res = width * height / 1000000.0;

            Console.WriteLine($"{width}x{height} => {Math.Round(res, 1)}MP");
        }
    }
}
