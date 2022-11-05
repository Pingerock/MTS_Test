using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Что выводится на экран? Измените класс Number так,
//чтобы на экран выводился результат сложения для
//любых значений someValue1 и someValue2.

//изначально программа выводила конкатенацию строк чисел someValue1 и someValue2
//я добавил несколько способов сложения, которые я отмечу в комментариях

namespace TestMTS
{
    internal class Task2
    {
        static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;
        class Number
        {
            //лучше заменить на модификатор private, чтобы можно было выполнять арифметические операции
            //помимо изначальной инициализации значения. Но я не уверен, можно ли мне вносить такие правки?
            readonly int _number;

            //конструктор, который задаёт значение для поля number,
            //если не указан никакой входной параметр
            public Number()
            {
                _number = 0;    
            }

            public Number(int number)
            {
                _number = number;
            }

            //добавил конструктор, который устанавливает значение поля _number,
            //принимая два параметра(слагаемые)
            public Number(int number1, int number2)
            {
                _number = number1 + number2;
            }

            //метод суммирования поля _number с одним входным аргументом
            //P.S.: будет работать только, если убрать модификатор readonly у поля _number
            //P.P.S.: добавлен конструктор без параметров, для случая инициализации класса
            //  и последующего применения метода sum.
            /*public void sum(int num)
            {
                _number += num;
            }*/

            public override string ToString()
            {
                return _number.ToString(_ifp);
            }
        }
        public static void Execute()
        {
            int someValue1 = 10;
            int someValue2 = 5;
            //изначальное сложение
            //string result = new Number(someValue1) + someValue2.ToString();

            //Сложение с помощью метода и конструктора без полей(нужно убрать модификатор readonly)
            /*Number number = new Number();
            number.sum(5);
            number.sum(10);
            string result = number.ToString();*/

            //Сложение с помощью конструктора
            Number number = new Number(someValue1, someValue2);
            string result = number.ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
