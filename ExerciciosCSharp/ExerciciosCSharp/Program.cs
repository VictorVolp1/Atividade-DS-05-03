using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Conversão de Temperatura");
            Console.WriteLine("2 - Área do Retângulo");
            Console.WriteLine("3 - Média de Alunos");
            Console.WriteLine("4 - Desconto em Produto");
            Console.WriteLine("5 - Contagem Regressiva");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: Exercicio1.Executar(); break;
                case 2: Exercicio2.Executar(); break;
                case 3: Exercicio3.Executar(); break;
                case 4: Exercicio4.Executar(); break;
                case 5: Exercicio5.Executar(); break;
                case 0: Console.WriteLine("Programa encerrado."); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        } while (opcao != 0);
    }
}