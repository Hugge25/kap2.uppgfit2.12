using System;

namespace kap2.uppgft2._12
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många kilometer ska du åka?");
            string km = Console.ReadLine();

            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string dagar = Console.ReadLine();
            
            int Dagar = int.Parse(dagar);
            int Km = int.Parse(km);

            Console.WriteLine(300+Km+(Dagar*500)-500);
        }
    }
}