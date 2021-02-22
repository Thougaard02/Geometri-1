using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPG A
            //Square square = new Square(90);
            //Square square1 = new Square(10);

            //Console.WriteLine(square.Omkreds());

            //Console.WriteLine(square.Areal());
            //Console.ReadKey();

            //OPG B
            Square square = new Square();
            square.Side = 10;
            Console.WriteLine(square.Omkreds());
            Console.WriteLine(square.Areal());
            Console.ReadKey();

        }
    }
}
