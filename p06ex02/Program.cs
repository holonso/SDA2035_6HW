using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из слов разделенных пробелами");
            string sentence = Console.ReadLine();
            string rwdSentence = new string(sentence.Reverse().ToArray());
            if (sentence == rwdSentence)
                Console.WriteLine("Предложение является палиндромом");
            else
                Console.WriteLine("Предложение не является палиндромом");
            Console.ReadKey();
        }
    }
}
