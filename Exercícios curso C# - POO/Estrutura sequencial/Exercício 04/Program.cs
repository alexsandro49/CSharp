using System;
using System.Globalization;
class Program
{   
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calcula o salário de um funcionário, levando em consideração a quantidade de horas trabalhadas:");
        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        
        System.Console.Write("Identificação do funcionário: ");
        ushort funcionarioId = ushort.Parse(Console.ReadLine());
        System.Console.Write("Número de horas trabalhadas: ");
        ushort horas = ushort.Parse(Console.ReadLine());
        System.Console.Write("Valor pago por hora: ");
        float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("=-=-=-=-=-=-=-=");
        System.Console.WriteLine($"ID = {funcionarioId}");
        System.Console.WriteLine($"Salário = {(valorHora * horas).ToString("C2")}");
    }
}