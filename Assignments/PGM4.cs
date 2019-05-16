using System;
namespace Program
{
    class Program4
    {
        public void fibonacci()
        {
            Int32 f1 = 0, f2 = 1, f3 = 0, i, count;
            Console.WriteLine("Enter the limit: ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibbonacci Series: ", f3);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 2; i < count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}