using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "технолог"; // обьявление и инициализация слова
            Console.Write($"n = {word.Length}");
            // вывод слова холл
            Console.Write(" " + word[2] + word[4] + word[5] + word[5]);
            // вывод слова лоно
            Console.Write(" " + word[5] + word[4] + word[3] + word[6]);
            Console.ReadKey(); // задержка экрана

        }
    }
}
