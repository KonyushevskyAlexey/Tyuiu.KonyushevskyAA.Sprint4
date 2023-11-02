using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint4.Task3.V11.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Конюшевский А.А | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("* 8, 6, 9, 4, 5,                                                          *");
            Console.WriteLine("* 9, 4, 8, 5, 6,                                                          *");
            Console.WriteLine("* 9, 7, 9, 8, 4,                                                          *");
            Console.WriteLine("* 4, 6, 5, 7, 8,                                                          *");
            Console.WriteLine("* 6, 6, 7, 6, 4,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arrayNums = new int[5, 5] { { 8, 6, 9, 4, 5 },
                                               { 9, 4, 8, 5, 6 },
                                               { 9, 7, 9, 8, 4 },
                                               { 4, 6, 5, 7, 8 },
                                               { 6, 6, 7, 6, 4 } };

            Console.WriteLine("Массив:");
            for (int i = 0; i < arrayNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNums.GetLength(1); j++)
                {
                    Console.Write($"{arrayNums[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество нечетных элементов = " + ds.Calculate(arrayNums));

            Console.ReadLine();
        }
    }
}
