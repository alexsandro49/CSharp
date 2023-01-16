using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o valor de um produto:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");

        System.Console.Write("Código do produto: ");
        ushort codigo = ushort.Parse(Console.ReadLine());
        System.Console.Write("Quantidade de peças: ");
        ushort quantidade = ushort.Parse(Console.ReadLine());
        System.Console.Write("Valor unitário do produto: ");
        float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Valor a se pagar: {(valor * quantidade):c2}");
    }
}