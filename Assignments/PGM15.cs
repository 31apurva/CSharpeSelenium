using System;
namespace Program
{
    class Program15
    {
        public void CountWords()
        {
            int count;
            string str;

            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();
            str = str.ToLower();
            String[] words = str.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        words[j] = "0";

                    }
                }
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(count);
            }

        }
    }
}