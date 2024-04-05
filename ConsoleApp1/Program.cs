using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKshka
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("баллы за первого задания 1: ");
            string task1 = Console.ReadLine();

            Console.WriteLine("баллы за первого задания 2: ");
            string task2 = Console.ReadLine();

            Console.WriteLine("баллы за первого задания 3: ");
            string task3 = Console.ReadLine();

            Console.WriteLine("баллы за первого задания 4: ");
            string task4 = Console.ReadLine();

            Console.WriteLine(GetMark(task1, task2, task3, task4));
            Console.ReadKey();

        }

        public static string GetMark(string _task1, string _task2, string _task3, string _task4)
        {

            int task1, task2, task3, task4;
            if (!int.TryParse(_task1, out task1) || !int.TryParse(_task2, out task2) || !int.TryParse(_task3, out task3) || !int.TryParse(_task4, out task4))
            {
                return "Некорректные значения!";
            }

            if (task1 > 10)
            {
                return "Неверное количество баллов для задания 1";
            }

            if (task2 > 50)
            {
                return "Неверное количество баллов для задания 2";
            }

            if (task3 > 30)
            {
                return "Неверное количество баллов для задания 3";
            }

            if (task4 > 10)
            {
                return "Неверное количество баллов для задания 4";
            }

            int result = (int)(task1 + task2 + task3 + task4);


            if (result < 20)
            {
                return $"Всего баллов: {result}. Оценка: 2";
            }

            else if (result < 40)
            {
                return $"Всего баллов: {result}. Оценка: 3";
            }

            else if (result < 70)
            {
                return $"Всего баллов: {result}. Оценка: 4";
            }
            else
            {
                return $"Всего баллов: {result}. Оценка: 5";
            }
        }
    }
}
