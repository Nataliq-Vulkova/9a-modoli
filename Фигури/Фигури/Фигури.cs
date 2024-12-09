using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигури
{
    internal class Фигури
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n=int.Parse(Console.ReadLine());
            for (var i = 1; i < n; i++)
            {
                for (var a = 1; a < n - 2; a++)
                    Console.WriteLine("+ - +");
                Console.WriteLine("| - |");
                for (var a = 1; a < i ; a++)
                    Console.WriteLine("+ - +");
                Console.WriteLine();
            }
        }
    }
}
