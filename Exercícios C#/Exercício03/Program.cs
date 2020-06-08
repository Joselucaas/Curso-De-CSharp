using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número real: ");
            float num;
            float.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("--------------------------------");

            int n1 = (int) num; // Ele só pega a aprte inteira do número, descartando o que vem depois da virgula
            int n2 = Convert.ToInt16(num); //Ele pega o número inteiro mais próximo

            Console.WriteLine($"Você digitou o valor {num:N3}");
            Console.WriteLine($"A parte inteira do número é {n1:D}");
            Console.WriteLine($"Arredondando, temos o número {n2:D}");

            Console.WriteLine("DIGITE OUTRO NÚMERO");
            int a;

            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine($"Você digitou o número {a}");
            Console.ReadKey();
        }
    }
}
