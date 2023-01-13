using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    public class Basics
    {
        static void Main(string[] args)
        {
            string str = "mishra";

            string[] arr = new string[] { "mi", "sh", "ra", "bc","bd" };
           var result = NumberofString(str, arr);
            Console.WriteLine(result);
            // Basic();
           // char c = 'a';
           // string str2 = "kmacbdegspf";
           // int[] pos = new int[] {1,4,6,7};
           // // SerachForchar(str, c);
           // //var result= ReverseString(str);
           // //  Console.WriteLine(result);
           // //SortedOrder(str2);
           // //FrquencyOfEachCharector(str);
           // //var result =  InsertCharAtCertaionPostion(str2, pos);
           // //  Console.WriteLine(result);
           //var rs = TwoStringsAreSameOrNot(str, str2);
           // Console.WriteLine(rs);
            //Insertchar();
        }

        public static void Basic()
        {
            //string str = "sandeep mishra";
            //Console.WriteLine(str


        }
        //will check leter
        public static void SerachForchar(string str, char c)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains(c))
                {
                    Console.WriteLine(str[i]);
                }
            }
        }

        public static string ReverseString(string str)
        {
            var revString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString += str[i];
            }
            return revString;
        }

        public static void SortedOrder(string str)
        {
            //by linq
            var result = str.OrderByDescending(x => x);
            foreach (var item in result)
            {
                Console.Write(item);
            }
            //foreach (var item in str)
            //{
            //    if(item < item + 1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }

        public static void FrquencyOfEachCharector(string str)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else
                {
                    dic[str[i]]++;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine("keys are : " + item.Key + " :" + " values are :" + item.Value);
            }
        }

        public static void SwapCharOfString(string str)
        {

        }

        public static string InsertCharAtCertaionPostion(string str, int[] ch)
        {

            string ans = "";

            int j = 0;

            for (int i = 0; i < str.Length; i++)
            {

                // If the count of characters
                // become equal to the stars[j],
                // append star
                if (j < ch.Length && i == ch[j])
                {
                    ans += '*';
                    j++;
                }
                ans += str[i];
            }

            return ans;
            //var newStr = "";
            //int j = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if( j < ch.Length && i == ch[j])
            //    {
            //        newStr += '*';
            //        j++;
            //    }
            //    newStr+= str[i];
            //}
            //return newStr;

        }

        //will check latter
        public static string Insertchar()
        {

            string str = "hi my name is * and i am from *";
            var builder = new StringBuilder(str);
            var arr = new string[] { "sandeep", "pune" };
            var result = "";
            int j = 0;
            for (int i = 0; i < builder.Length; i++)
            {

            }
        
            return result;

           
        }
       
        //wrong
        public static bool TwoStringsAreSameOrNot (string str, string str2) 
        { 
            bool flag = false;
            var s1 = str.ToCharArray();
            var s2 = str2.ToCharArray();

            for (int i = 0; i <s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                       return true;
                    }
                }
            }

            return flag;
        }

        public static string Removevhar(string str, char s)
        {
            //var arr = str.ToCharArray();
            var builder = new StringBuilder(str);
            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == s)
                {
                    builder.Remove(2, i);
                }
                i--;
            }
            return builder.ToString();
        }

        public static int NumberofString( string word, string[] patterns)
        {
            //Input: patterns = ["a","abc","bc","d"], word = "abc"
            // Output: 3
            var counter = 0;
            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                {
                    counter++;
                }
            }
            return counter;

        }

        public static bool isAlive(string str)
        {
            var hs = new HashSet<char>(new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            var fst = 0;
            var snd = 0;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (hs.Contains(str[i]))
                {
                    fst++;
                }
            }
            for (int j = str.Length / 2; j <str.Length ; j++)
            {
                if (hs.Contains(str[j]))
                {
                    snd++;
                }
            }
            return fst == snd;

        }

        public static string GenerateString(int n)
        {
            var sb = new StringBuilder();
            if(n/2==0)
            {
                sb.Append('a', n);
            }
            else
            {
                sb.Append('a',n-1);
                sb.Append('b');
            }
            return sb.ToString();
        }

        public static void Destination(IList<IList<string>> paths)
        {
            foreach (var item in paths)
            {
                foreach (var res in item)
                {

                }
            }
        }

        public bool SquareIsWhite(string coordinates)
        {
            var x = coordinates[0] - 'a';
            var y = coordinates[1] - '1';
            return (x + y) % 2 != 0;
        }
    }

}
}
