using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoExtensionMethods
    {
        static void Main(string[] args)
        {
            int num = 234;
            num.IsEvenNumber();//int.IsEvenNumber(this num);
            Console.WriteLine("********");
            string str = "Hello All";
            str.CountVowels();
            Console.WriteLine("********");
            int consonant = 0;
            int vowCnt = str.CountVowelsConsonants(ref consonant);
            Console.WriteLine("the number of vowels in the given string = " + vowCnt);
            Console.WriteLine("the number of consonants in the given string = " + consonant);
            Console.WriteLine("********");
            string msg = "";
            Console.ReadLine();
        }
    }
    public static class MyExtensionMethods
    {
        public static void IsEvenNumber(this int n)
        {
            Console.WriteLine((n%2==0)?n+" is an even number": n + " is an odd number");
        }
        public static void Reverse(this int num)
        {

        }
        public static void CountVowels(this string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    count++;
            }
            Console.WriteLine("the number of vowels in the given string = "+count);
        }

        public static int CountVowelsConsonants(this string s,ref int consonantCount)
        {
            int count = 0;
            consonantCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    count++;
                else
                    consonantCount++;
            }
            //Console.WriteLine("the number of vowels in the given string = " + count);
            return count;
        }
    }
}
