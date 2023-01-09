using System;
class maioresDe18 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Verifica quantas pessoas tem mais de 18 anos:");

        byte maiores = 0;
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write($"Digite a idade da pessoa {i+1}: ");
            byte pessoa = byte.Parse(Console.ReadLine());

            if (pessoa >= 18) {
                maiores++;
            }
        }

        System.Console.WriteLine($"Exitem {maiores} pessoas com mais de 18 anos");
    }
}