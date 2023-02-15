using System;
using System.Globalization;

class mediaHarmonica
{   
    public static void Main(string[] args)
    {
        Console.WriteLine("Calcula a média harmônica das notas de um aluno");
        Console.WriteLine("=-=-=-=-=-=-=");

        float[] notas = new float[4];

        for (byte i = 0; i < 4; i++)
        {
            Console.Write($"Informe a {i+1}° nota: ");
            notas[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("=-=-=-=-=-=-=");
        Console.WriteLine($"Média harmônica: {4 / ((1/notas[0]) + (1/notas[1]) + (1/notas[2]) + (1/notas[3])):f2}");
    }
}