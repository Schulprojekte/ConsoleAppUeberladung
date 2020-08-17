using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÜberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechnen1();
            Console.WriteLine();
            Console.ReadKey();
            rechnen1("Brötchen");
            Console.ReadKey();
        }

        private static int variable1 = 10;
        private static int variable2 = 25;
        private static int variable3;
        private static string variable4;

        private static void Rechnen1()
        {
            //variable3=variable1 + variable2;
            //Console.WriteLine(variable3);
            Console.WriteLine(variable3 = variable1 + variable2);
        }

        private static void rechnen1(string text1)
        {
            variable4 = text1;
            Console.WriteLine(variable1 + " " + variable4);
        }
    }
}