using System;
using System.Globalization;

class salarioDeUmVendedor
{   
    public static void Main(string[] args)
    {
        Console.WriteLine("Calcula o salário total de um vendedor:");
        Console.WriteLine("=-=-=-=-=-=-=");

        int id, totalDeVendas;
        float salarioFixo, percentualDeGanho;

        Console.Write("Informe o código do funcionário (***): ");
        id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe o salário fixo atual: R$");
        salarioFixo = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Total de vendas realizadas: ");
        totalDeVendas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Percentual sobre vendas (%): ");
        percentualDeGanho = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("=-=-=-=-=-=-=");

        Console.WriteLine($"Informações do funcionário: \nId: {id} \nPercentual de ganho: {percentualDeGanho}% \nTotal de Vendas: {totalDeVendas} \nSalário total: R${salarioFixo + (totalDeVendas * (percentualDeGanho / 100)):f2}");
    }
}