using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário! Escreva algo e veja como o Cebolinha diria isto.");

            string cebola = Console.ReadLine();

            Console.WriteLine(cebola .Replace("r" , "l"));
            Console.ReadKey();
        }
    }
}
