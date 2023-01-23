using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class Class1
    {
        /// <summary>
        /// Определяет состоит ли число только из нечётных цифр
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>true, если число состоит только из нечётных цифр; в обратном случае - false</returns>
        public static bool IsEven(int number)
        {
            bool even = true;
            int digit;

            while (number >= 1)
            {
                digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    even = false;
                    break;
                }
            }
            return even;
        }

        /// <summary>
        /// Находит сумму наименьших двух чисел из трёх введённых
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <param name="num3">Третье число</param>
        /// <returns>Сумма двух наименьших чисел из трёх введённых</returns>
        public static int SmallerNumbersSum(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;

            if (num1 >= num2 && num1 >= num3) sum -= num1;
            else if (num2 >= num1 && num2 >= num3) sum -= num2;
            else sum -= num3;

            return sum;
        }

        /// <summary>
        /// Находит номер первого нечётного элемента
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        /// <returns>Номер первого нечётного элемента. Если его нет, возвращает -1</returns>
        public static int FirstOddElement(int[] arr)
        {
            int index = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Формирует одномерный массив из сумм элементов столбцов матрицы
        /// </summary>
        /// <param name="matr">Матрица</param>
        /// <returns>Массив</returns>
        public static int[] ColumnsSum(int[,] matr)
        {
            int[] arr = new int[matr.GetLength(1)];

            for(int j = 0; j < matr.GetLength(1); j++)
                for(int i = 0; i < matr.GetLength(0); i++) arr[j] += matr[i, j];
            return arr;
        }
    }
}
