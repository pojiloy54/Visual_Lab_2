using System;

namespace Visual_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumber test1 = new RomanNumber(20);
            Console.WriteLine($"1 число = {test1.ToString()}");
            RomanNumber test2 = new RomanNumber(5);
            Console.WriteLine($"2 число = {test2.ToString()}");
            RomanNumber test3 = RomanNumber.Add(test1, test2);
            Console.WriteLine($"Сложение = {test3.ToString()}");
            RomanNumber test4 = RomanNumber.Sub(test1, test2);
            Console.WriteLine($"Вычитание = {test4.ToString()}");
            RomanNumber test5 = RomanNumber.Mul(test1, test2);
            Console.WriteLine($"Умножение = {test5.ToString()}");
            RomanNumber test6 = RomanNumber.Div(test1, test2);
            Console.WriteLine($"Целочисленное деление = {test6.ToString()}");
            Console.WriteLine($"Изначальный массив {test3.ToString()}");
            var clon = (RomanNumber)test3.Clone();
            Console.WriteLine($"Клонирование {clon.ToString()}");
            RomanNumber sort1 = new RomanNumber(25);
            RomanNumber sort2 = new RomanNumber(4);
            RomanNumber sort3 = new RomanNumber(10);
            RomanNumber[] mas = { sort1, sort2, sort3 };
            Console.WriteLine($"\nИзначальный массив");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
            Array.Sort(mas);
            Console.WriteLine($"\nСортированный массив");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
        }
    }
}
