using System;

namespace Ejercicio1DeGabrielBenitez
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Conversión de pesos a dólares");

            var dolar = 230;
            var euro = 1.17;
            Console.Write("Ingrese la cantidad de pesos: ");
            var pesos = Convert.ToDouble(Console.ReadLine());

            VerificarPesos(pesos, dolar);

            Console.WriteLine($"Con {pesos} pesos se compran {VerificarPesos(pesos, dolar)} dólares");
            Console.WriteLine($"Con {VerificarPesos(pesos, dolar)} dólares se compran {VerificarEuro(pesos, dolar, euro)} euros");
            Console.ReadKey();
        }

        private static double VerificarPesos(double pesos, double dolar)
        {
            dolar = pesos / dolar;
            return dolar;

        }
        private static double VerificarEuro(double pesos, double dolar, double euro)
        {
            dolar = pesos / dolar;
            euro = euro * dolar;
            return euro;

        }

    }
}
