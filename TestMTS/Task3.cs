using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реализуйте метод по следующей сигнатуре:
// <summary>
// <para> Отсчитать несколько элементов с конца </para>
// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4,0)</example>
// </summary>
// <typeparam name="T"></typeparam>
// <param name="enumerable"></param>
// <param name="tailLength">Сколько элеметнов отсчитать с конца (у последнего элемента tail = 0)</param>
// <returns></returns>

//Возможно ли реализовать такой метод выполняя перебор значений перечисления только 1 раз?

namespace TestMTS
{

    public static class Task3
    {
        public static void Execute()
        {
            foreach(var obj in new[] { 1,2,3,4 }.EnumerateFromTail(2))
            { 
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }

        private static IEnumerable<(int number, int? tail)> EnumerateFromTail(this IEnumerable enumerable, int tailLength)
        {
            int i = 0;
            int t;
            if (tailLength > GetLength(enumerable))
            {
                t = GetLength(enumerable);
            }
            else
            {
                t = tailLength;
            }
            foreach (int number in enumerable)
            {
                if (i == GetLength(enumerable) - t)
                {
                    t--;
                    yield return (number, t);
                }
                else
                {
                    yield return (number, null);
                }
                i++;
            }
        }

        //считает длину коллекции
        private static int GetLength(IEnumerable collection)
        {
            int length = 0;
            foreach (object obj in collection)
            {
                length++;
            }
            return length;
        }
    }
}
