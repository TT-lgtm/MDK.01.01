using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_pr8.Classes
{
     class Parallepiped
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        //объём- V=a*b*c
        public double GetVolume()
        {
            return Length * Width * Height;
        }

        //площадь поверхности- S= 2*((a*b)+(a*c)+(b*c))
        public double GetSurfaceArea()
        {
            return 2 * ((Length * Width) + (Length * Height) + (Width * Height));
        }

        public void ShowInfo()
        {
            Console.WriteLine("Прямоугольный параллепипед: ");
            Console.WriteLine("Длина: "+ Length);
            Console.WriteLine("Ширина: "+ Width);
            Console.WriteLine("Высота: "+ Height);
            Console.WriteLine("Объём: " + GetVolume());
            Console.WriteLine("Площадь поверхности: " + GetSurfaceArea());
        }

    }
}
