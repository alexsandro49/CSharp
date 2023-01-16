using System;
using System.Globalization;
class fahrenheitParaCelsius 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Converte a temperatura de Fahrenheit para Celsius:");
        
        System.Console.Write("Informe a temperatura em Fahrenheit (°F): ");
        float temp = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"{temp:f1}°F é igual a {((temp - 32) / 1.8f):f1}°C.");
    }
}