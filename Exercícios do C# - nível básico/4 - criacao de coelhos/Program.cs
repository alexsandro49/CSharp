using System;
class criacaoDeCoelhos 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o custo para criação de coelhos:");

        System.Console.Write("Informe o total de coelhos: ");
        ushort coelhos = ushort.Parse(Console.ReadLine());

        float custo = coelhos * 0.7f * 8;
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"Uma criação com {coelhos} coelhos, terá um custo de {custo:c}");
    }
}