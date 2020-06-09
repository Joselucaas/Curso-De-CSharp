using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lendo produto 1
            Console.Write("Produto 1: ");
            string n1 = Console.ReadLine();

            Console.Write("Peço 1: R$");
            float p1;
            float.TryParse(Console.ReadLine(), out p1);

            // Lendo produto 2
            Console.Write("Produto 2: ");
            String n2 = Console.ReadLine();

            Console.Write("Preço 2: R$");
            float p2;
            float.TryParse(Console.ReadLine(), out p2);

            // Resultado
            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"Produto ", -20}{"Preço ", 13}");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine($"{n1, -20}{p1, 13:C}");
            Console.WriteLine($"{n2,-20}{p2,13:C}");

            Console.ReadKey();
        }
    }
}
