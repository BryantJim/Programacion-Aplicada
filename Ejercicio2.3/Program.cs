using System;

namespace Ejercicio2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            double Grados, resultado=0;
            double P = 3.1416;

            Console.Write("Ingrese los grados a convertir: ");
            entrada = Console.ReadLine();
            Grados = Convert.ToDouble(entrada);

            resultado = Grados * P / 180;

            Console.WriteLine("\nEl resultado es: {0} radianes", resultado);
        }
    }
}
