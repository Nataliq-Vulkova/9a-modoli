using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *    *        *       * * * * * *     *        *  ");
            Console.WriteLine(" *    *       *  *          *          *      * *  ");
            Console.WriteLine(" * ** *      * ** *         *          *    *   *  ");
            Console.WriteLine(" *    *     *      *        *          *  *     *  ");
            Console.WriteLine(" *    *    *        *       *          *        *  ");


            Console.Write("Как се казваш?");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравей, {name}!");
            Console.Write("Как е името на номер 17");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Може би, {name1} ще се опита да завърши");

        }
    }
}
