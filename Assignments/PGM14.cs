using System;
namespace Program
{
    class Program14
    {
        public void NumOfWorlds()
        {
            string str;
            int len = 1, word = 1;
            Console.Write("Enter the string: ");
            str = Console.ReadLine();
            
            while (len <= str.Length - 1)
            {
                if (str[len] == ' ' || str[len] == '\n' || str[len] == '\t')
                {
                    word++;
                }
                len++;
            }
            Console.WriteLine("Number of words in string is : "+word);
        }


    }

}