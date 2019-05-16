using System;
using System.Text.RegularExpressions;
namespace Program
{
    class Program10
    {
        public void Remove_special_character()
        {
            String str;
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();
            char [] ch = str.ToCharArray();
            string strrep=Regex.Replace(str, @"[^0-9a-zA-Z]+", ",");
            Console.WriteLine(strrep);
        } 
    }

}