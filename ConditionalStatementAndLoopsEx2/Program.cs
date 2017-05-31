using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchSum = int.Parse(Console.ReadLine());

            char first=' ';
            char second=' ';
            char third=' ';
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1: first = 'A'; break;
                    case 2: first = 'C'; break;
                    case 3: first = 'G'; break;
                    case 4: first = 'T'; break;
                }
                for (int j = 1; j <= 4; j++)
                {
                    switch (j)
                    {
                        case 1: second = 'A'; break;
                        case 2: second = 'C'; break;
                        case 3: second = 'G'; break;
                        case 4: second = 'T'; break;
                    }

                    for (int k = 1; k <= 4; k++)
                    {
                        int total = i + j + k;

                        switch (k)
                        {
                            case 1: third = 'A'; break;
                            case 2: third = 'C'; break;
                            case 3: third = 'G'; break;
                            case 4: third = 'T'; break;
                        }

                        if (total >= matchSum)
                        {
                            Console.Write("O" + first + second + third + "O ");
                        }
                        else
                        {
                            Console.Write("X" + first + second + third + "X ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
