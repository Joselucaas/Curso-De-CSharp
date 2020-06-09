using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercício07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("--------------------------");

            Console.Write("INÍCIO: ");
            int x;
            int.TryParse(Console.ReadLine(), out x);

            Console.Write("FIM: ");
            int y;
            int.TryParse(Console.ReadLine(), out y);

            Random sorteio = new Random();
            int num = sorteio.Next(x, y);

            Console.WriteLine("--------------------------");

            string nome = "SORTEANDO";
            Console.WriteLine(nome);
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 5);
            nome = ($"Entre {x} e {y} o número sorteado foi {num}");
            Console.WriteLine(nome);

            Console.ReadKey();
        }
    }
}
