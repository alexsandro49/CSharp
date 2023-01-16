using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Com a leitura de 3 valores, calcula as áreas do triângulo retângulo, círculo, trapézio, quadrado e triângulo isósceles:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");

        System.Console.Write("Informe o valor de A: ");
        float valorA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o valor de B: ");
        float valorB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o valor de C: ");
        float valorC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Área do triângulo retângulo (base: A, altura: C): {(valorA * valorC / 2).ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área do círculo (raior: C): {(Math.PI * Math.Pow(valorC, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área do trapézio (bases: A e B, altura: C): {((valorA + valorB) / 2 * valorC).ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área do quadrado (lados: B): {(Math.Pow(valorB, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área do retângulo (lados: A e B): {(valorA * valorB).ToString("F3", CultureInfo.InvariantCulture)}");
    }
}