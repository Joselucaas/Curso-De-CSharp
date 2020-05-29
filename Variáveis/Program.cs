using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade = 25;
            ushort publico = 45_239;
            float media = 9.8f; // Sempre que usar o tipo float tem que colocar o f no final do número.
            decimal estrelas = 725.87456515683m;   // Semnpre que usar o decimal tem que colocar o m no final do número.
            bool gravidez = false;

            Console.WriteLine("José tem " + idade + " anos de idade!");
            Console.WriteLine("No jogo entre Flamengo e Vasco teve um público pagante de " + publico +".");
            Console.WriteLine("Rafael ficou com a média " + media + " em Física.");
            Console.WriteLine("A galáxia tem " + estrelas + " de estrelas.");
            Console.WriteLine("O texte de gravidez de Mônica deu " + gravidez + ".");
            Console.ReadKey();
        }
    }
}
