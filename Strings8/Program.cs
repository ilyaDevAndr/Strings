using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: "); // вывод на экран
            string firstString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write("Введите строку: "); // вывод на экран
            string secondString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write(firstString.Replace("ск", secondString)); // замена последнего слога у первой строки 
            Console.ReadKey(); // задержка экрана 
        }
    }
}
