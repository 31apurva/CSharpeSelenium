using System;
using ServiceProject;

namespace ServiceProject
{
    public class CountWords
    {
        public int NumOfWorlds()
        {
            string str="Good Morning, Have a Nice Day";
            int len = 0;
            Console.WriteLine(str);
            String[] strarr=str.Split(' ');
            len += strarr.Length;
            return len;
        }
    }
}
