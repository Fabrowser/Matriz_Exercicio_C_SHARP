using System;

namespace Exercicio_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de LINHAS da MATRIZ: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de COLUNAS da MATRIZ: ");
            int n = int.Parse(Console.ReadLine());


            int[,] mat = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--MATRIZ--\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Digite um valor que está na matriz: ");
            int x = int.Parse(Console.ReadLine());


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("\nPosição: (" + i + "," + j+")");
                        Console.WriteLine("---------------------");
                        if (j != 0)
                        {
                            Console.WriteLine("À esquerda: " + mat[i, j - 1] + " ");
                        }

                        if (j != n - 1)
                        {
                            Console.WriteLine("À direita: " + mat[i, j + 1] + " ");
                        }
                        if (i != 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j] + " ");
                        }

                        if (i != m - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j] + " ");
                        }

                    }
                }
                Console.WriteLine();
            }

        }
    }
}
