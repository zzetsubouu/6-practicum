using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            //Random rnd = new Random();
            //int value = rnd.Next();
            //Console.WriteLine($"случайное число - {value}");
            //string a = (value % 2 == 0) ? "оно четное" : " оно нечетное";
            //Console.WriteLine(a);

            //Задача 2. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            //Console.Write("введите номер ня недели");
            //int day = int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("пн");
            //        break;
            //    case 2:
            //        Console.WriteLine("вт");
            //        break;
            //    case 3:
            //        Console.WriteLine("ср");
            //        break;
            //    case 4:
            //        Console.WriteLine("чт");
            //        break;
            //    case 5:
            //        Console.WriteLine("пт");
            //        break;
            //    case 6:
            //        Console.WriteLine("сб");
            //        break;
            //    case 7:
            //        Console.WriteLine("вс");
            //        break;
            //}


            //Задача 3. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //Random rnd = new Random();
            //int day = rnd.Next(1,8);
            //Console.WriteLine(day);
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("пн");
            //        break;
            //    case 2:
            //        Console.WriteLine("вт");
            //        break;
            //    case 3:
            //        Console.WriteLine("ср");
            //        break;
            //    case 4:
            //        Console.WriteLine("чт");
            //        break;
            //    case 5:
            //        Console.WriteLine("пт");
            //        break;
            //    case 6:
            //        Console.WriteLine("сб");
            //        break;
            //    case 7:
            //        Console.WriteLine("вс");
            //        break;
            //}




            //Задача 4. По номеру месяца вывести название времени года.
            //Console.Write("введите номер месяца ");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("март");
            //        break;
            //    case 4:
            //        Console.WriteLine("апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("май");
            //        break;
            //    case 6:
            //        Console.WriteLine("июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("август");
            //        break;
            //    case 9:
            //        Console.WriteLine("сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("декабрь");
            //        break;
            //}
            //Задача 5. Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.
            //Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
            //Console.Write("введите транспортное средство:  a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд");
            //string vehicle = Console.ReadLine();
            //switch (vehicle)
            //{
            //    case "а":
            //        Console.WriteLine("максимальная скорость автомобиля - 120 км/ч");
            //        break;
            //    case "в":
            //        Console.WriteLine("максимальная скорость велосипеда - 30 км/ч");
            //        break;
            //    case "м":
            //        Console.WriteLine("максимальная скорость мотоцикла - 200 км/ч");
            //        break;
            //    case "с":
            //        Console.WriteLine("максимальная скорость самолета - 920 км/ч");
            //        break;
            //    case "п":
            //        Console.WriteLine("максимальная скорость поезда - 90 км/ч");
            //        break;
            //}


            //Задача 6. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            //Console.WriteLine("введите название предмета: ф – физика, м – математика, и – история, г – география, б – биология");
            //string subject = Console.ReadLine();
            //switch (subject)
            //{
            //    case "ф":
            //        Console.WriteLine("физика");
            //        break;
            //    case "м":
            //        Console.WriteLine("математика");
            //        break;
            //    case "и":
            //        Console.WriteLine("история");
            //        break;
            //    case "г":
            //        Console.WriteLine("география");
            //        break;
            //    case "б":
            //        Console.WriteLine("биология");
            //        break;
            //}
            //(доп задание) дан признак геометрической фигуры на плоскости К,к-круг П,п - прямоугольник, Т,т - треугольник.
            //Вывести на экран периметр и площадь заданной фигуры с учетом что данные необходимые для расчета запрашивают у пользователя
            Console.WriteLine("введите название геометрической фигуры на плоскости К,к-круг П,п - прямоугольник, Т,т - треугольник");
            char subject = Convert.ToChar(Console.ReadLine());
            switch (subject)
            {
                case 'К':
                case 'к':
                    Console.WriteLine("введите радиус круга");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double pK = 2*Math.PI*r;
                    double sK = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"площадь круга = {sK:N2}, длина окружности = {pK:N2}");
                    break;
                case 'П':
                case 'п':
                    Console.WriteLine("введите 1 сторону");
                    double s1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите 2 сторону");
                    double s2 = Convert.ToDouble(Console.ReadLine());
                    double pP = (s1 + s2) * 2;
                    double sP = s1 * s2;
                    Console.WriteLine($"периметр прямоугльника = {pP:N2},площадь = {sP:N2}");
                    break;
                case 'Т':
                case 'т':
                    Console.WriteLine("введите 1 сторону");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("введите 2 сторону");
                    int side2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("введите 3 сторону");
                    int side3 = int.Parse(Console.ReadLine());
                    
                    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
                    {
                        double pT = (side1 + side2 + side3) / 2.0;
                        double sT = Math.Sqrt(pT * (pT - side1)*(pT - side2) * (pT - side3));
                        Console.WriteLine($"периметр треугольника = {(side1+side2+side3):N2}, площадь = {sT:N2}");
                    }
                    else
                    {
                        Console.WriteLine("треугольника не существует");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
