using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2_pr8.Classes
{
    class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        public Zakaz (string fm, int sz, string cmf) //3
        { fam= fm; size = sz; comfort= cmf; }
        public Zakaz(string fm, int sz) //2
        { fam = fm; size = sz; comfort = "стандарт"; }
        public Zakaz(string fm) //1
        { fam = fm; size = 3; comfort = "стандарт"; }
        public Zakaz() //без
        { fam = "неизвестный"; size = 6; comfort = "хостел"; }
        public void Show()
        {
            Console.WriteLine("Пользователь {0} забронировал {1} местный номер класса {2}",
                fam,size,comfort);
        }
    }
}
