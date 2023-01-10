using System;
using System.Globalization;

class volumeDeUmaEsfera 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o volume de uma esfera:");
        
        System.Console.Write("Informe o raio da esfera (cm): ");
        float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"A esfera com {raio:f1}cm de raio, tem {((4 * Math.PI * Math.Pow(raio, 3)) / 3):f1}cm² de volume.");
    }
}