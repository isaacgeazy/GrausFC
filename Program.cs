using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double celsius, fare;

              Console.WriteLine("----- Conversão de Fahrenheit para Celsius -----");
              Console.WriteLine();
              Console.WriteLine("valor em Fahrenheit: ");
              entrada = Console.ReadLine();

              fare = Convert.ToDouble(entrada);

              celsius = (fare - 32) / 1.8;

              Console.WriteLine();
              Console.WriteLine($"A conversão de Fahrenheit para Celsius é {celsius}");

        }
    }
}
