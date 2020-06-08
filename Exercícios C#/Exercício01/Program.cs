using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 5);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("MEU ");          
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("BRASIL ");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("BRASILEIRO");
            Console.ReadKey();
        }
    }
}
