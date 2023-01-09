using System;
class mediaIdades 
{   
    public static void Main(string[] args)
    {

        byte[] idades = new byte[5];

        System.Console.WriteLine("Programa para calcular a idade média entre 5 alunos:");
        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"Idade do aluno {i+1}: ");
            idades[i] = byte.Parse(Console.ReadLine());    
        }

        float soma = 0;
        foreach (var item in idades)
        {
            soma += item;
        }

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"A média entre as idades é: {soma / 5:f1}");
    }
}