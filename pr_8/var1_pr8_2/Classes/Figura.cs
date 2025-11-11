using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_pr8_2.Classes
{
     class Figura
    {
        public void ShowArea(double a) //квадрат
        {
            double area = a * a;
            Console.WriteLine("Фигура: квадрат");
            Console.WriteLine("Сторона = " + a);
            Console.WriteLine("Площадь = " + area);
        }

        public void ShowArea(double a, double b) //треугольник
        {
            double area = a * b;
            Console.WriteLine("Фигура: прямоугольник");
            Console.WriteLine("Стороны = " + a + " и " + b);
            Console.WriteLine("Площадь = " + area);
        }

        public void ShowArea(double a, double b, double h) //трапеция
        {
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Фигура: трапеция");
            Console.WriteLine("Основания = " + a + " и " + b + ", высота = " + h);
            Console.WriteLine("Площадь = " + area);
        }
    }
}
