using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    public class SubStringAndSubSequence
    {
        static void Main(string[] args)
        {
            var str = "abcd";
            PrintAllSubstring(str);
        }

        public static void PrintAllSubstring(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                var substr = "";
                for (int j = i; j < str.Length; j++)
                {
                    substr += str[j];
                    Console.WriteLine(substr);
                }
            }
        }

        public static void PrintAllSubSequence(string str)
        {

        }
    }
}
