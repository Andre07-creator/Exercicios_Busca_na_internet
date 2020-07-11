using System;
using Busca_Na_Internet.Entite;
namespace Busca_Na_Internet
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            Link_3 _3 = new Link_3(t);

            Console.WriteLine(_3.PrimeiroLink());
        }
    }
}
