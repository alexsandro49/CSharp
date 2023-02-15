using System;
using System.Globalization;
class adicaoEProdutoDeFracoes
{   
    public static void Main(string[] args)
    {
        float[] fracoes = new float[4];
        
        Console.WriteLine("Calcula a soma e o produto de duas frações");
        Console.WriteLine("=-=-=-=-=-=-=");

        Console.Write($"Informe o numerador para a 1° fração: ");
        fracoes[0] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write($"Informe o denominador para a 1° fração: ");
        fracoes[1] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("=-=-=-=-=-=-=");

        Console.Write($"Informe o numerador para a 2° fração: ");
        fracoes[2] = float.Parse(Console.ReadLine());
        Console.Write($"Informe o denominador para a 2° fração: ");
        fracoes[3] = float.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=");

        float soma, produto;
        
        if (fracoes[1] == fracoes[3]) {
            soma = (fracoes[0] + fracoes[2]) / (fracoes[1]);
        } else {
            soma = (fracoes[0] + fracoes[2]) / (fracoes[1] + fracoes[3]);
        }
        
        produto = (fracoes[0] * fracoes[2]) / (fracoes[1] * fracoes[3]);

        Console.WriteLine($"Fração A = {fracoes[0]} / {fracoes[1]} \nFração B = {fracoes[2]} / {fracoes[3]}");
        Console.WriteLine("=-=-=-=-=-=-=");

        Console.WriteLine($"A sua soma (A + B): {soma:f2}");
        Console.WriteLine($"A sua produto (A * B): {produto:f2}");
    }
}