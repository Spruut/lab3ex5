using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            int[,] array2 = new int[5, 5];
            Random rand = new Random();

            WriteMatrix(array1);
            WriteMatrix(array2);
            Console.WriteLine();
            int[,] result = MultiMatrix(array1, array2);
            WriteMatrix(result);

            for (int i = 0; i< array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rand.Next(0, 9);
                    array2[i, j] = rand.Next(0, 9);
                }
            }
            static void WriteMatrix(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            static int[,] MultiMatrix(int[,] array1, int[,] array2)
            {
                int[,] result = new int[5, 5];

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(0); j++)
                    {
                        for (int k = 0; k < array1.GetLength(1); k++)
                            result[i, j] += array1[i, k] * array2[k, j];
                    }
                }
                return result;
            }
        }
    }
}
