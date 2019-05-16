using System;
namespace Program
{
    class Program11
    {
        public void Reverse_String()
        {
            string str, str1 = "";
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();

            int len;

            len = str.Length - 1;
            for (int i = len; i >= 0; i--)
            {
                str1 = str1 + str[i];

            }
            Console.WriteLine("Reverse String is: " + str1);
            char[] str2 = str.ToCharArray();
            Array.Reverse(str2);
            Console.WriteLine("Reverse String using function: " + new string(str2));
        }
    }
}