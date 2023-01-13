using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    public class EasyPractice
    {
        public static void Main(string[] args)
        {
            var arr = new string[] { "sandeep", "mishra", "sandeep", "kumar" };

            // MostReaptedChar(arr);

            FrequencyOfWord(arr);
        }

        public static void MostReaptedChar(string[] arr)
        {
            var max = ' ';
            var dic = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else { dic[arr[i]]++; }
            }
            // greatest key
            var maxKey = dic.Keys.Max();

            // greatest value
            var maxValue = dic.Values.Max();

            Console.WriteLine(maxKey + maxValue);

        }

        public static void FrequencyOfWord(string[] arr)
        {
            //Linq
            var result = arr.GroupBy(x => x).Select(x => new { word = x.Key, count = x.Count() }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic.TryAdd(arr[i], 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public static void MissingNumberInArray(int[] arr)
        {
            
        }

        public string FrsitPalindromicWord(string[] arr)
        {
            if(arr.Length ==0 ||  arr == null) return "";

            foreach (var item in arr)
            {
                if (Ispalindrome(item))
                {
                    return item;
                }     
            }
            return "";
        }

        private bool Ispalindrome(string item)
        {
            int i =0;
            int j = item.Length - 1;
            while (i <j)
            {
                if (item[i] != item[j])
                return false;
                i++;
                j--;
            }
            return true;
           
        }




    }
}
