using System;

namespace калькулятор
{
    class Program { 
static class MyClass
    {
        public static int DifferenceYear(DateTime one, DateTime two)
        {
            int total = one.Year - two.Year;
            if (two.Month > one.Month || (two.Month == one.Month && two.Day > one.Day))
                return total - 1;
            return total;
        }

        public static int DifferenceMonth(DateTime one, DateTime two)
        {
            int total = (one.Year - two.Year) * 12 + one.Month - two.Month;
            if (two.Day > one.Day || (two.Month == one.Month && two.Day > one.Day))
                return total - 1;
            return total;
        }
    }
    
        static void Main(string[] args)
        {
            DateTime InputDT;
            double a, b;
            string oper;

            Console.WriteLine("Какая операция вам нужна? (+,-,*,/,Объем,Возраст)");
            oper = Console.ReadLine();
            
            
            switch (oper)
            {

                case "Возраст":
                    Console.WriteLine("Формат даты:Год,месяц,день(2000.01.11)");
                    if (!DateTime.TryParse(Console.ReadLine(), out InputDT))
                    {
                        Console.WriteLine("Неверный формат даты");
                    }
                    else
                    {
                        Console.WriteLine("Года:" + MyClass.DifferenceYear(DateTime.Now, InputDT));
                        Console.WriteLine("Месяцы: " + MyClass.DifferenceMonth(DateTime.Now, InputDT));
                        Console.WriteLine("Дни: " + (DateTime.Now - InputDT).Days);
                        
                    }
                    break;
                case "+":
                    Console.WriteLine("Введите число №1:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число№2 :");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine("Введите число №1:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число№2 :");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine("Введите число №1:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число№2 :");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;


                case "/":
                    Console.WriteLine("Введите число №1 :");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число№2 :");
                    b = double.Parse(Console.ReadLine());

                    if (b == 0)
                    {
                        Console.WriteLine("Айяяй!!Нельзя так!");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;

                case "Объем":
                    Console.WriteLine("Введите число №1(Радиус):");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число№2(Высота) :");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Площадь поверхности  = {0}", 2 * Math.PI * a * (b + a));
                    Console.WriteLine("Объем  = {0}", Math.PI * a * a * b);
                    break;
               
               default:
                    Console.WriteLine("Ошибка");
                    break;
            }
    }
             
            }
        }