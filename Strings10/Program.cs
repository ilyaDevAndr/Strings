using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Слово: "); // Вывод на экран
            string word = Console.ReadLine(); // обьявление и инициализация слова
            Console.Write("Буква: "); // вывод на экран
            char letter = Convert.ToChar(Console.ReadLine()); // обьявление и инициализация символа
            int result = word.IndexOf(letter);
            Console.WriteLine($"Буква 'р' имеет индекс {result}");
            Console.ReadKey(); // задержка экрана 

        }
    }
}
