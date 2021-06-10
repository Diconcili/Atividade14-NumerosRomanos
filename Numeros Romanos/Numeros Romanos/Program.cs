using System;
using System.Threading.Tasks;

namespace Numeros_Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorArábicos conversor = new ConversorArábicos(3000);
            Console.WriteLine(conversor.nRomano);
            ConversorRomanos conversor1 = new ConversorRomanos("X̄");
            Console.WriteLine(conversor1.nArabico);
            Console.ReadKey(); 
        }
    }
}
