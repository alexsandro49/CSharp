using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Soma de dois valores:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");

        System.Console.Write("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"SOMA = {(n1 + n2).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}