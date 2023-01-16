using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula a área de um círculo:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        
        System.Console.Write("Informe o raio (cm): ");
        float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Área do círculo: {(Math.PI * Math.Pow(raio, 2)).ToString("F4", CultureInfo.InvariantCulture)}cm²");
    }
}