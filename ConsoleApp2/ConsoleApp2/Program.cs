using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть значення змiнної alfa");
            double alfa = Convert. ToDouble( Console.ReadLine());
            Console.WriteLine("Введiть значення змiнної beta");
            double beta = Convert.ToDouble(Console.ReadLine());

            double z1 = Math.Pow((Math.Cos(alfa)),2) - Math.Pow((Math.Sin(beta)),2);
            double z2 = -4 * ((Math.Pow((Math.Sin), 2))((alfa - beta) / 2) * Math.Cos(alfa + beta)) ;
            Console.WriteLine($"z1={z1}",$"z2={z2}");
                


        }
    }
}
