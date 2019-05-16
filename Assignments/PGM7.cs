using System;
namespace Program
{
    class Program7
    {
        public void reversearray()
        {
            int n, i;

            
            Console.WriteLine("Enter number of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Array elements are: ");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Array elements in reverse Order: ");
            for (i = n-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}