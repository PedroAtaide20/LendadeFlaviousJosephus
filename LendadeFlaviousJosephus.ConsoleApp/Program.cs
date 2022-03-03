using System;

namespace LendadeFlaviousJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de homens: ");
            int quantidadeHomens = int.Parse(Console.ReadLine());

            int[] homens = new int[quantidadeHomens + 1];

            Console.Write("Digite o tamanho do salto entre os homens: ");
            int tamanhoSalto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeHomens; i++)
            {
                homens[i] = i;
            }

            int j = 1, x = 0, y = 0;
        }
    }
}
