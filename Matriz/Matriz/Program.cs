using System;
using System.Globalization;


namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            double[,] mat = new double[2, 3];

            //Retorna o tamanho da matriz

            Console.WriteLine(mat.Length);
            //retorna a dimensão da matriz
            Console.WriteLine(mat.Rank);
            //retorna a primeira dimensão da matriz(linhas)
            Console.WriteLine(mat.GetLength(0));
            //retorna a segunda dimensão da matriz (coluna)
            Console.WriteLine(mat.GetLength(1));
            



            Console.Write("Informe a ordem da matriz: ");
            int orderMatriz = int.Parse(Console.ReadLine());

            int[,] mat = new int[orderMatriz,orderMatriz];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                 for (int j = 0; j < mat.GetLength(1); j++)
                {
                    
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < orderMatriz; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int numberNegatives = 0;

            for (int i = 0;i < mat.GetLength(0); i++)
            {
                for (int j = 0; j <mat.GetLength(1); j++)
                {


                    if (mat[i,j]< 0)
                    {
                        numberNegatives += 1;

                    }



                }
            }


            Console.WriteLine("Negative Numbers: " + numberNegatives);
            */

            string[] value = Console.ReadLine().Split(' ');
            int m = int.Parse(value[0]);
            int n = int.Parse(value[1]);


            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int findNumber = int.Parse(Console.ReadLine());




            for (int i = 0;i < m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i,j] == findNumber)
                    {
                        Console.WriteLine($"Position {i}, {j}: ");
                        // esquerda
                        if(j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j- 1]}");
                        }
                        //cima
                        if(i > 0) {
                            Console.WriteLine($"Up: {mat[i- 1, j]}");
                        
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {mat[i+1, j]}");
                        }

                    }
                }
            }




        }
    }
}