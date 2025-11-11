using System;
using System.Drawing;
using example2_pr8.Classes;

//Пример 2:
//Заказ номеров в гостинице. Использование перегрузки конструкторов.

class Program
{

    static void Main(string[] args)
    {
        /*Zakaz z1=new Zakaz("Иванов", 1, "Люкс");
        z1.Show();
        Zakaz z2 = new Zakaz("Петров", 2);
        z2.Show();
        Zakaz z3 = new Zakaz("Сидоров");
        z3.Show();
        Zakaz z4 = new Zakaz();
        z3.Show(); Console.ReadKey();*/
        while (true)
        {
            //ФАМИЛИЯ
            Console.WriteLine("Введите фамилию (или Q для выхода. Enter- неизвестный): ");
            string fam = Console.ReadLine().Trim();

            if (fam.ToUpper() == "Q")
                break;

            //КОЛ-ВО МЕСТ
            string sizee;
            int size = 0;
            while (true)
            {
                Console.WriteLine("Введите количество мест (число, или Q для выхода. Enter- 6 мест): ");
                sizee = Console.ReadLine().Trim(); //Trim() для удаления пробелов

                if (sizee.ToUpper() == "Q")
                    return;

                if (sizee == "")
                    break;

                if (int.TryParse(sizee, out size) && size > 0) //проверка, чтобы польз. вводил только положит. число
                    break;
                else
                    Console.WriteLine("Ошибка! Введите положительное число.");
            }

            //КОМФОРТ
            string comfort;
            while (true)
            {
                Console.WriteLine("Введите класс комфорта (эконом, бизнес, или Enter— стандарт): ");
                comfort = Console.ReadLine().Trim().ToLower(); //ToLower() для нижнего регистра

                if (comfort == "")
                    break;

                if (comfort == "эконом" || comfort == "бизнес")
                    break;
                else
                    Console.WriteLine("Ошибка! Введите только эконом или бизнес.");
            }

            //ЗАКАЗ
            Zakaz z;

            if (fam == "" && sizee == "" && comfort == "")
                z = new Zakaz();
            else if (sizee == "" && comfort == "")
                z = new Zakaz(fam);
            else if (comfort == "")
                z = new Zakaz(fam, size);
            else
                z = new Zakaz(fam, size, comfort);

            z.Show();
            Console.WriteLine("\n");
        }

        Console.WriteLine("Программа завершена.");
    }
}

