using System;
class imparOuPar 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Determina se um número pe ímpar ou par:");
        
        System.Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        if (numero % 2 == 0) {
            System.Console.WriteLine($"O número {numero} é par!");
        }
        else {
            System.Console.WriteLine($"O número {numero} é ímpar!");
        }
    }
}