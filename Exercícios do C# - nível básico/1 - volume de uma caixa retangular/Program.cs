﻿using System;
using System.Globalization;
class volumeDeUmaCaixaRetangular 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o volume de uma caixa retangular:");
        
        System.Console.Write("Informe o comprimento da caixa (cm): ");
        float comprimento = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe a largura da caixa (cm): ");
        float largura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe a altura da caixa (cm): ");
        float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Uma caixa com as dimensões: {comprimento:f1}cm x {largura:f1}cm x {altura:f1}cm");
        System.Console.WriteLine($"Possui um volume de {(comprimento * largura * altura):f1}cm².");
    }
}