using System;
using System.Globalization;
class distributiva 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Mostra a distributiva da soma e multiplicação entre 4 números:");
        
        System.Console.Write("Informe o primeiro número: ");
        float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o segundo número: ");
        float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o terceiro número: ");
        float c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Informe o quarto número: ");
        float d = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"A soma entre {a} e {b}, é: {(a + b):f2}");
        System.Console.WriteLine($"A soma entre {a} e {c}, é: {(a + c):f2}");
        System.Console.WriteLine($"A soma entre {a} e {d}, é: {(a + d):f2}");
        System.Console.WriteLine($"A soma entre {b} e {c}, é: {(b + c):f2}");
        System.Console.WriteLine($"A soma entre {b} e {d}, é: {(b + d):f2}");
        System.Console.WriteLine($"A soma entre {c} e {d}, é: {(c + d):f2}");

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"A multiplicação entre {a} e {b}, é: {(a * b):f2}");
        System.Console.WriteLine($"A multiplicação entre {a} e {c}, é: {(a * c):f2}");
        System.Console.WriteLine($"A multiplicação entre {a} e {d}, é: {(a * d):f2}");
        System.Console.WriteLine($"A multiplicação entre {b} e {c}, é: {(b * c):f2}");
        System.Console.WriteLine($"A multiplicação entre {b} e {d}, é: {(b * d):f2}");
        System.Console.WriteLine($"A multiplicação entre {c} e {d}, é: {(c * d):f2}");
    }
}