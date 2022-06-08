using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)

        {

            double v, t, d;
            Console.Write("  la ruta 117: ");
            int.Parse(Console.ReadLine());

            Console.Write(" el tiempo estimado de la ruta:");
            int.Parse(Console.ReadLine());


            Console.WriteLine("ingrese velocidad:");
            v = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese distancia:");
            d = int.Parse(Console.ReadLine());

            t = v * d;

            Console.WriteLine("El estimado es tiempo es = {0}", t);
            Console.ReadKey();
        }
    }
}
