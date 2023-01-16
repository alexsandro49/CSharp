using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula a diferença entre o produto de A e B pelo produto de C e D:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");

        System.Console.Write("Valor de A: ");
        float valorA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Valor de B: ");
        float valorB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Valor de C: ");
        float valorC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Valor de D: ");
        float valorD = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Diferença: {(valorA * valorB - valorC * valorD).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}