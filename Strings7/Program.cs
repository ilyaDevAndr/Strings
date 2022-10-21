using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: "); // вывод на экран
            string firstString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write("Введите строку: "); // вывод на экран
            string secondString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write(firstString.Remove(firstString.Length - 3).Insert(2, secondString)); // вывод на экран замену последнего слога на 3 символа слова
            Console.ReadKey(); // задержка экрана 
        }
    }
}
