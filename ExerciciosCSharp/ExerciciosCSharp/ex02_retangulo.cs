using System;

static class Exercicio2
{
    public static void Executar()
    {
        Console.Write("Base: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Altura: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Área: " + (b * a));
    }
}