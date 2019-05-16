using System;
namespace Program
{
    public class Program6
    {
        public void stringarray()
        {
            int n, i = 0;
            String value;
            string[] str = new string[10];
            Console.WriteLine("Enter number of string values ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("String values are: ");
            for (i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the string value to find ");
            value = Console.ReadLine();
            int flag = 0, index = 0;



            for (i = 0; i < n; i++)
            {
                if (str[i].Equals(value))
                {
                    flag = 1;
                    index = i;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Value present in string array at position", index + 1);
            }
            else
                Console.WriteLine("Value not present in String array");

        }

    }
}