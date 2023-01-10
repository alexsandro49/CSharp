using System;
class mediaIdades 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Programa para calcular a idade média entre 5 alunos:");
        
        float soma = 0;
        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"Idade do aluno {i+1}: ");
            soma += byte.Parse(Console.ReadLine());    
        }

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"A média entre as idades é: {soma / 5:f1}");
    }
}