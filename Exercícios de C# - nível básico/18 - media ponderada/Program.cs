using System;
using System.Globalization;

class mediaPonderada
{   
    public static void Main(string[] args)
    {
        Console.WriteLine("Calcula a média ponderada das notas de um aluno");
        Console.WriteLine("=-=-=-=-=-=-=");

        float[] notas = new float[2];
        float[] pesos = new float[2];

        for (byte i = 0; i < 2; i++)
        {   
            Console.Write($"Informe a {i+1}° nota: ");
            notas[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Informe o peso da nota {i+1}: ");
            pesos[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("=-=-=-=-=-=-=");
        Console.WriteLine($"Média ponderada: {(((notas[0] * pesos[0]) + (notas[1] * pesos[1])) / (pesos[0] + pesos[1])):f2}");
    }
}