using System;

namespace lab_5._1_15v
{
    class Program
    {
        static void Main(string[] args)
        {
             //5.1 базовый уровень 15v
            Console.WriteLine("Введите строку ");
            string a = Console.ReadLine();
            int count = 0;
            foreach (char c in a)
                if (c == '('||c==')') count++;
            Console.WriteLine("Количество круглых скобок:" + count);
            foreach (char c in a)
                if (c == ']' || c == '[') count++;
            Console.WriteLine("Количество квадратных скобок:" + count);
        }
        }
    }

