using System;
using pr_8.Classes;

//Пример1 в лаб.р.№8. Работа выполнена студентом ИП-23-3, Лаптева В.В.
class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();
        dom1.name = "Дача"; dom1.area = 30; dom1.floor = 6; dom1.kvo = 4;
        dom1.ShowInfo();

        Build dom2 = new Build("Коттедж", 80, 8, 6);
        dom2.ShowInfo();
        }
    }
