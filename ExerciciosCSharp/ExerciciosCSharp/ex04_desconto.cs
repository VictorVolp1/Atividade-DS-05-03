using System;

static class Exercicio4
{
    public static void Executar()
    {
        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Desconto (%): ");
        double desc = Convert.ToDouble(Console.ReadLine());

        double final = preco - (preco * desc / 100);

        Console.WriteLine("Preço final: " + final);
    }
}