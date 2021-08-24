// Calcular el area de un circulo

using System;

namespace p02_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio=0; // definir variable
            double area=0;
            Console.WriteLine("Calculando el area de un circulo");
            Console.WriteLine("Dame el radio?");
            radio = float.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radio,2); // elevar al cuadrado
            Console.WriteLine($"El area del circulo es {area}");
        }
    }
}
