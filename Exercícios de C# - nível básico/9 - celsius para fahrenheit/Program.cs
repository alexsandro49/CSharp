using System;
using System.Globalization;
class celsiusParaFahrenheit 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Converte a temperatura de Celsius para Fahrenheit:");
        
        System.Console.Write("Informe a temperatura em Celsius (°C): ");
        float temp = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float novaTemp = temp * 1.8f + 32;
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"{temp:f1}°C é igual a {novaTemp:f1}°F.");
    }
}