using System;
using System.Globalization;
class consumoDeCombustivel 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Informa o consumo médio de combustível em uma viagem:");

        System.Console.Write("Distância percorrida (km): ");
        float distancia = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Consumo de combustível (l): ");
        float consumo = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"O consumo médio foi de {(distancia / consumo):f1}km/h.");
    }
}