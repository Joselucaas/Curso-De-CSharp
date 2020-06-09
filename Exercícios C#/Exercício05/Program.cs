using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int ano;
            int.TryParse(Console.ReadLine(), out ano);
            Console.WriteLine("--------------------------------------");
            
            Console.WriteLine($"Estamos atualmente no ano de {DateTime.Now.Year}.");
            int idade = DateTime.Now.Year - ano;
            Console.WriteLine($"Se você nasceu em {ano}, vai ter {idade} anos.");
                       
            Console.ReadKey();
        }
    }
}
