﻿using System;
using System.Globalization;
class volumeDeUmCilindro 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o volume de um cilindro:");

        System.Console.Write("Informe o raio do cilindro (cm): ");
        float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe a alura do cilindro (cm): ");
        float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"O cilindro com altura: {altura:f1}cm e raio: {raio:f1}cm");
        System.Console.WriteLine($"Possui {(Math.PI * Math.Pow(raio, 2) * altura):f2}cm² de volume.");
    }
}