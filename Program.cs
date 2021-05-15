using System.Collections.Generic;

namespace kata
{
    class Program
    {
        static void Main(string[] args)
        {
            string result =  ReverseWords("dogecoin to the moon");
            System.Console.WriteLine(result);
        }
        private static string ReverseWords(string str)
        {
            string[] p = str.Split(' ');
            List<string> temp = new List<string>();
            for (int i = p.Length - 1; i >= 0; i--)
            {
                temp.Add(p[i]);
            }
            return string.Join(" ", temp);
        }
    }
}
