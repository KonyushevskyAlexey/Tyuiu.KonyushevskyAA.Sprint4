using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Конюшевский А.А | ИИПБ-23-2";
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                       *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                                                            *");
            Console.WriteLine("* Задание #5                                                                                                      *");
            Console.WriteLine("* Вариант #9                                                                                                      *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович  | ИИПБ-23-2                                                        *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -4 до 4.  *");
            Console.WriteLine("* Найти количество положительных элементов.                                                                       *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

            Console.WriteLine("Введите количество строк массива");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("*******************************************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-4, 5);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t")
                        ;
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Количество положительных элементов = " + res);
            Console.ReadKey();
        }
    }
}
