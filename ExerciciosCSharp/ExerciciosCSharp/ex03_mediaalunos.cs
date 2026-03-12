using System;

static class Exercicio3
{
    public static void Executar()
    {
        Console.Write("Digite a primeira nota: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        Console.WriteLine("Média do aluno: " + media);
    }
}