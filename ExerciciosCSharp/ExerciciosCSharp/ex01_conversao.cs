using System;

static class Exercicio1
{
    public static void Executar()
    {
        Console.Write("Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit: " + f);
    }
}