using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_VaporStore
{
    class p2_VaporStore
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var gameName = Console.ReadLine();


            var price = 0.0;
            var budget = balance;
            
            while (gameName != "Game Time")
            {
                var name = "";
                switch (gameName)
                {
                    case "OutFall 4":
                        price = 39.99;
                        name = "OutFall 4";
                        break;
                    case "CS: OG":
                        price = 15.99;
                        name = "CS: OG";
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        name = "Zplinter Zell";
                        break;
                    case "Honored 2":
                        price = 59.99;
                        name = "Honored 2";
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        name = "RoverWatch";
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        name = "RoverWatch Origins Edition";
                        break;
                    default:
                        price = 0.0;
                        Console.WriteLine("Not Found");
                        break;

                }
                if (price != 0)
                {

                    if (price > budget)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= price;
                        Console.WriteLine($"Bought {name}");
                    }

                    if (budget == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                gameName = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${(balance - budget):F2}. Remaining: ${budget:F2}");


        }
    }
}
