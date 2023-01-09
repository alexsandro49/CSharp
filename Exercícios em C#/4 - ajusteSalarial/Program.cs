using System;

class ajusteSalarial 
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Mostra o novo salário de 10 funcionários, após um ajuste:");
        
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            System.Console.Write("Informe o salário atual R$: ");
            float salario = float.Parse(Console.ReadLine());

            float novoSalario = 0;
            if (salario <= 300) {
                novoSalario = salario * 1.5F;
            }
            else {
                novoSalario = salario *  1.3F;
            }

            System.Console.WriteLine($"O funcionário passará a ganhar: {novoSalario:c}");
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}