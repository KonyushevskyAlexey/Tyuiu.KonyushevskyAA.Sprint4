using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint4.Task4.V22.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Конюшевский А.А   | ИИПБ-23-2";
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                       *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                                                    *");
            Console.WriteLine("* Задание #4                                                                                                      *");
            Console.WriteLine("* Вариант #22                                                                                                     *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович  | ИИПБ-23-2                                                        *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 2 до 6. *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                                                        *");
            Console.WriteLine("* 4, 3, 2, 4, 5,                                                                                                  *");
            Console.WriteLine("* 5, 4, 5, 6, 6,                                                                                                  *");
            Console.WriteLine("* 6, 2, 3, 6, 5,                                                                                                  *");
            Console.WriteLine("* 6, 2, 3, 6, 4,                                                                                                  *");
            Console.WriteLine("* 6, 2, 6, 6, 2,                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

            Console.WriteLine("Введите количество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество строк массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("\nИзмененный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        
        }
    }
}
