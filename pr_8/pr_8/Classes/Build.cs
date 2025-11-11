using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8.Classes
{
    class Build
    {
        public string name;
        public double area;
        public int floor;
        public int kvo;
        

        public Build() { }
        
        public Build(string nm, double ar, int flo, int k)
        { this.name = nm;  this.area = ar; this.floor = flo;  this.kvo = k;}
        

            public void ShowInfo()
            {
                Console.WriteLine("В доме {0} площадью {1} и {2} этажами живёт {3} чел, на человека {4:f2}",
                    name, area, floor, kvo, area / kvo);
            }
    }
}
