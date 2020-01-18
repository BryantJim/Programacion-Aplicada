using System;

namespace Ejercicio2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            String Entrada = "";
            double Dolar = 0, Euro = 0, TasaDolar = 0, TasaEuro = 0, Dolares = 0, Euros = 0;

            Console.Write("Cantidad de dolares a convertir a Euro: ");
            Entrada = Console.ReadLine();
            Dolar = Convert.ToDouble(Entrada);

            Console.Write("Cantidad de Euro a convertir a dolares: ");
            Entrada = Console.ReadLine();
            Euro = Convert.ToDouble(Entrada);

            Console.Write("Tasa del dolar a euro: ");
            Entrada = Console.ReadLine();
            TasaDolar = Convert.ToDouble(Entrada);

            Console.Write("Tasa del euro a dolar: ");
            Entrada = Console.ReadLine();
            TasaEuro = Convert.ToDouble(Entrada);

            Dolares = Dolar * TasaEuro;
            Euros = Euro * TasaDolar;

            Console.WriteLine("De dolar a Euro: {0}",Euros);
            Console.WriteLine("De Euro a Dolar: {0}",Dolares);
        }
    }
}
