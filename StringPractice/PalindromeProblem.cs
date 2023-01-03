using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    public class PalindromeProblem
    {
        static void Main(string[] args)
        {
            string str = "abc ";
            Palindrome(str);
        }

        public static void Palindrome(string str)
        {
            var revString = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                revString += str[i];
            } 
            if(revString == str)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        public static void CheckIfStringReArrangedAsPalindorm(string str)
        {

        }
    }
}
