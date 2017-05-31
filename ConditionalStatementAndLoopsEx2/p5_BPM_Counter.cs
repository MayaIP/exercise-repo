using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5_BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = int.Parse(Console.ReadLine());
            var beatsC = int.Parse(Console.ReadLine());

            
            double bars = Math.Round(beatsC / 4.0, 1);

            int beatsCf = beatsC * 60;
            int lenghtInSec = beatsCf / bpm;
            int minutes = lenghtInSec / 60;
            int seconds = lenghtInSec % 60;

            //var minutes = 0;
            //if (lenghtInSec > 59)
            //{
            //    minutes++;
            //    lenghtInSec -= 60;
            //}

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
