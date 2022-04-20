using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bU tasKI metHodla yAzmAliSiz");
            string str = Console.ReadLine();
            string str1 = "Bu Taski Methodla Yazmalisiz";
            foreach (char c in str1)
            {
                if (char.IsUpper(c))
                    str1 += Char.ToLower(c);
                
                    
            }
            Console.WriteLine(str1);

        }
    }
}
