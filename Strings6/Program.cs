using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию и имя: ");
            string s1 = Console.ReadLine(); // обьявление и инициализация строки
            Console.Write("Введите фамилию и имя: ");
            string s2 = Console.ReadLine(); // обьявление и иницализация строки
            Console.WriteLine("Поменяли местами, получилось: ");
            Console.Write(String.Concat(s2, ", ", s1)); // вывод на экран
            Console.ReadKey(); // задержка экрана

        }
    }
}
