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
                number = number / 10;

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
    }
}
