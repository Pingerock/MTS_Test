using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализуйте метод Sort. Известно, что потребители метода зачастую не будут вычитывать данные до конца.
//Оптимально ли Ваше решение с точки зрения скорости выполнения? С точки зрения потребляемой памяти?

/// <summary>
/// Возвращает отсортированный по возрастанию поток чисел
/// </summary>
/// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда
///чисел.</ param >
/// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось
///число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
/// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не
///превышающее 2000.</param>
/// <returns>Отсортированный по возрастанию поток чисел.</returns>

namespace TestMTS
{
    public static class Task4
    {

        public static void Execute()
        {
            //генерируем коллекцию
            Random random = new Random();
            int maxValue = 2000;
            //в условии задачи указано, что длина потока данных не превышает миллиарда,
            //но создание потока на миллиард символов вызывает OutOfMemory. Неприятно.
            IEnumerable<int> numbers = RandomSequence(random, maxValue).Take(100000);
            //выполняем сортировку
            numbers.Sort(757, maxValue);
            //выводим
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static IEnumerable<int> Sort(this IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            //копируем коллекцию
            var values = inputStream;
            //освобождаем память от оригинальной коллекции
            inputStream = null;
            //сортируем(можно самостоятельно создать алгоритм quicksort или merge sort,
            //но я не представляю как использовать его с IEnumerable)
            values = values.OrderBy(x => x).Where(x => x > x - sortFactor);
            //не получилось. Это плохо.
            //выводим отсортированный поток чисел
            return values;
        }

        private static IEnumerable<int> RandomSequence(Random random, int maxValue)
        {
            while (true)
            {
                yield return random.Next(0, maxValue);
            }
        }
    }
}
