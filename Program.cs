using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] massive = new int[N, M];
            vvod(massive, N, M);
            vyvod(massive, N, M);

            Console.WriteLine('\n');
            int n1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            int[,] massiveA = new int[n1, m1];

            int n2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int[,] massiveB = new int[n2, m2];


            if (m1 == n2)
            {
                int[,] massiveC = new int[n2, m1];
                vvod(massiveA, n1, m1);
                vvod(massiveB, n2, m2);
                vyvod(massiveA, n1, m1);
                Console.WriteLine();
                vyvod(massiveB, n2, m2);
                Console.WriteLine();
                MatrixMultiplication(massiveA, massiveB, massiveC, n1, m1, n2, m2);
            }
            Console.ReadKey();
        }
        static void vvod(int[,] massiv, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    massiv[i, j] = rnd.Next(0, 30);
                }
            }
        }
        static void vyvod(int[,] massiv, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(massiv[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        static void MatrixMultiplication(int[,] matrixA, int[,] matrixB, int[,] matrixC, int N1, int M1, int N2, int M2)
        {       
            for (var i = 0; i < N1; i++)
            {
                for (var j = 0; j < M2; j++)
                {
                    for (var k = 0; k < M1; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                        Console.Write(matrixC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
