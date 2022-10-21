using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Студент"; // обьявление и инициализация строки
            string s2 = "колледжа"; // обьявление и иницализация строки
            Console.Write(String.Concat(s1, "  ", s2)); // вывод на экран
            Console.ReadKey(); // задержка экрана

        }
    }
}
