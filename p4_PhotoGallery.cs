using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNum = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            else
            {
                orientation = "portrait";
            }

            var format = "";
            var photoSizeF = 0.0;
            if (photoSize < 1000)
            {
                photoSizeF = photoSize;
                format = "B";
            }
            else if (photoSize > 999 && photoSize <= 999999)
            {
                format = "KB";
                photoSizeF = photoSize / 1000.0;
            }
            else if (photoSize > 999999 )
            {
                format = "MB";
                photoSizeF = photoSize/1000000.0;
            }
            Console.WriteLine($"Name: DSC_{photoNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {photoSizeF}{format}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
