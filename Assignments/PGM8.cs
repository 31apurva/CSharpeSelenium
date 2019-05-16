using System;
namespace Program
{
    class Program8
    {
        public void max_min_array()
        {
            int max, min, n, i;
           
            Console.WriteLine("Enter the number of array: ");
            n = Convert.ToInt32(Console.ReadLine());
             int[] num = new int[n];
            Console.WriteLine("Enter elements of array : ");
            for (i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = num[0];
            max = num[0];
            for (i = 1; i < n; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("Maximum element is : "+max);
            Console.WriteLine("Minimum element is : "+min);

        }
    }
}