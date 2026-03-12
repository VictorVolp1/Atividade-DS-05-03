using System;

static class Exercicio5
{
    public static void Executar()
    {
        Console.Write("Número inicial: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}