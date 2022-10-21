using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: "); // вывод на экран
            string firstString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write("Введите строку: "); // вывод на экран
            string secondString = Console.ReadLine(); // обьявление и инициализация переменной
            Console.Write(firstString.Remove(firstString.Length - 3).Insert(2, secondString)); // замена последнего слога у первой строки 
            Console.ReadKey(); // задержка экрана
        }
    }
}
