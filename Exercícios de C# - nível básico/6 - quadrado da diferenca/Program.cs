using System;
using System.Globalization;

class quadradoDaDiferenca 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o quadrado da diferença entre dois números:");
        
        System.Console.Write("Informe o primeiro número: ");
        float n1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o segundo número: ");
        float n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"O quadrado da diferença entre {n1:f2} e {n2:f2}, é: {(Math.Pow(n1, 2) - Math.Pow(n2, 2)):f2}");
    }
}