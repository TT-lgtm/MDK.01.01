using System;
using var1_pr8_2.Classes;

//Индивидуальное задание 2 в лаб.р.№8, вариант 1
// 1 вариант. Класс Figura. Метод ShowArea перегружен.
// В зависимости от количества введенных параметров выводится название фигуры
// (один параметр – квадрат, два – прямоугольник, три – трапеция),
// вычисляется и выводится площадь.
class Program
{
    static void Main(string[] args)
    {
        Figura f = new Figura();

        while (true)
        {
            Console.WriteLine("Выберите фигуру (1 — квадрат, 2 — прямоугольник, 3 — трапеция, Q — выход):");
            string choice = Console.ReadLine().Trim().ToUpper(); //ToUpper() для Q

            if (choice == "Q")
                break;

            if (choice == "1")
            {
                Console.WriteLine("Введите сторону квадрата: ");
                double a = double.Parse(Console.ReadLine());//Parse()- чтобы преобразовать текст в число с плав. точкой
                f.ShowArea(a);
                Console.WriteLine("\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Введите первую сторону прямоугольника:");
                double a = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Введите вторую сторону прямоугольника:");
                double b = double.Parse(Console.ReadLine());
                f.ShowArea(a, b);
                Console.WriteLine("\n");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Введите первое основание трапеции:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе основание трапеции:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту трапеции:");
                double h = double.Parse(Console.ReadLine());
                f.ShowArea(a, b, h);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите 1, 2, 3 или Q.");
                Console.WriteLine("\n");
            }
        }

        Console.WriteLine("Программа завершена.");
    }
}
