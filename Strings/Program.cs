using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "автоматизация"; // обьявление и инициализация слова
            Console.Write($"n = {word.Length}");
            // вывод слова зима
            Console.Write(" " + word[8] + word[7] + word[4] + word[0]);
            // вывод слова заяц
            Console.Write(" " + word[8] + word[9] + word[12] + word[10]);
            Console.ReadKey(); // задержка экрана

        }
    }
}
