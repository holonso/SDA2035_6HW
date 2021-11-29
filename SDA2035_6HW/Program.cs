using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_6HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из слов разделенных пробелами");
            string sentence = Console.ReadLine();
            char[] probel = new char[] { ' ' };
            string[] words = sentence.Split(probel, StringSplitOptions.RemoveEmptyEntries);
            int maxcharN = 0;
            string maxchar = "";
            foreach (string s in words)
            {
                if (s.Length > maxcharN)
                {
                    maxcharN = s.Length;
                    maxchar = s;
                }
            }
            Console.WriteLine("Самое длинное слово в строке - {0}", maxchar);
            Console.ReadKey();
        }
    }
}
