using System;
namespace Program
{
    class Program5
    {
        public void convertarray()
        {
            int row = 0, column = 0;
            Console.Write("Enter number of rows and column for metric: ");
            row = Convert.ToInt32(Console.ReadLine());
            column = Convert.ToInt32(Console.ReadLine());
            int[,] arr2D = new int[row, column];
            int[] arr1D = new int[row * column];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            int k = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr1D[k++] = arr2D[i, j];
                }
            }
            for (int i = 0; i < row * column; i++)
            {
                Console.Write(arr1D[i] + " ");
            }

        }
    }
}