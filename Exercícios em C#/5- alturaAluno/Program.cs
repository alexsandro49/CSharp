using System;
using System.Globalization;

class alturaAluno 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Indica o maior e o menor aluno:");

        int maiorMat = 0, menorMat = 0;
        float maiorAltura = 0, menorAltura = 0;
        
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write("Matricula do aluno: ");
            int mat = int.Parse(Console.ReadLine());

            System.Console.Write("Altura do aluno (m): ");
            float alt = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (i == 0) {
                maiorAltura = alt;
                maiorMat = mat;
                menorAltura = alt;
                menorMat = mat;
                continue;
            }
            if (alt >= maiorAltura) {
                maiorAltura = alt;
                maiorMat = mat;
            }
            else if (alt <= menorAltura) {
                menorAltura = alt;
                menorMat = mat;
            }
        }

        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine("Maior altura:");
        System.Console.WriteLine($"Mat: {maiorMat}, Altura: {maiorAltura:f2}m");
        System.Console.WriteLine("Menor altura:");
        System.Console.WriteLine($"Mat: {menorMat}, Altura: {menorAltura:f2}m");
    }
}