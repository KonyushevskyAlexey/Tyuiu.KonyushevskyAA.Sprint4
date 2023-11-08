using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint4.Task7.V14.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Конюшевский А.А | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #14                                                                                                *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович    | ИИПб-23-2                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 458712659137. Преобразуйте ее в матрицу 3 на 4                           *");
            Console.WriteLine("* и подсчитайте сумму нечетных чисел.                                                                        *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int n = 3;
            int m = 4;
            int index = 0;
            string str = "458712659137";
            int[,] array = new int[n, m];
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива: ");
            int res = ds.Calculate(n, m, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
