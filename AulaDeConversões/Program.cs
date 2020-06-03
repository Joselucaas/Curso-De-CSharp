using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDeConversões
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Conversão Implícita int -> float
            /*  int a = 8;
                float b = a;
                Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType() );
                Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType()); */



            // Conversão Explícita float -> int (typecast)
            /* float a = 87.785f; // Só coloca o f quando a variavel float tiver ponto(vírgula)
             int b = (int) a; // O (int) só vai pegar a parte inteira
             Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
             Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());*/




            // Conversão Por Classes Auxiliares

            float a = 8.25f;
            int b = Convert.ToInt32(a);
            Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());

            Console.ReadKey();
    
        }
    }
}
