using System;
namespace Program
{
    class Program9
    {
        public void Join_Split_Trim()
        {
            int i;
            Console.WriteLine("Enter number of string ");
            int n = Int32.Parse(Console.ReadLine());
            string[] str = new string[n];
            Console.WriteLine("Enter the string values:  ");
            for (i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string b = str[i].Trim();
            Console.WriteLine(b);


            
            for (i = 0; i < n; i++)
            {
            string[] a = str[i].Split(" ");
            foreach (string s3 in a)
            {
                Console.WriteLine(s3);
            }

            string c = string.Join("|", a);
            Console.WriteLine(c);
        }

        }
    }

}