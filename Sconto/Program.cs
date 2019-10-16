using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il prezzo del primo prodotto: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il prezzo del secondo prodotto: ");
            double p2 = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            double totale;
            if (p1 > p2)
            {
                sconto = p2 / 100 * 50;
                scontato = p2 - sconto;
                totale = p1 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            else
            {
                sconto = p1 / 100 * 50;
                scontato = p1 - sconto;
                totale = p2 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            Console.ReadLine();
        }
    }
}
