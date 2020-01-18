using System;

namespace Ejercicio2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            double GradosCelsius, GradosFahrenheit=0;

            Console.Write("Ingrese la cantidad de grado celsius: ");
            entrada = Console.ReadLine();
            GradosCelsius = Convert.ToDouble(entrada);

            GradosFahrenheit = GradosCelsius * 9 / 5 + 32;

            Console.WriteLine("\nEl resultado en Grados Fahrenheit: {0}", GradosFahrenheit);
        }
    }
}
