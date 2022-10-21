using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "таблица"; // обьявление и инициализация слова
            Console.Write($"n = {word.Length}");
            // вывод слова бита
            Console.Write(" " + word[2] + word[4] + word[0] + word[1]);
            // вывод слова бал
            Console.Write(" " + word[2] + word[1] + word[3]);
            Console.ReadKey(); // задержка экрана

        }
    }
}
