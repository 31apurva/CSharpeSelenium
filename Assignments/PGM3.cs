using System;
namespace Program
{
    class Program3
    {
        public void pattern()

        {
            Int32 i, j, rows;
            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}