using System;
namespace Program
{
    class Program12
    {
        public void Merge_String()
        {
            String str1, str2;
            int l1, l2;
            Console.Write("Enter first string: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            str2 = Console.ReadLine();
            l1 = str1.Length;
            l2 = str2.Length;
            char[] concatstring = new char[l1 + l2];
            for (int i = 0; i < l1; i++)
            {
                concatstring[i] = str1[i];
            }
            for (int i = 0; i < l2; i++)
            {
                concatstring[i + l1] = str2[i];
            }
            Console.WriteLine(concatstring);
            char[] prependstring = new char[l2 + l1];
            for (int i = 0; i < l1; i++)
            {
                prependstring[i + l2] = str1[i];
            }
            for (int i = 0; i < l2; i++)
            {
                prependstring[i] = str2[i];
            }
            Console.WriteLine(prependstring);

        }
    }
}