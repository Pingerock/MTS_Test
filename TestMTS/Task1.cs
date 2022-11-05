using System;
using System.Collections.Generic;
using System.IO;

//Реализуйте метод FailProcess так, чтобы процесс завершался.
//Предложите побольше различных решений.

namespace TestMTS
{
    internal class Task1
    {
        public static void Execute()
        {
            try
            {
                FailProcess();
            }
            catch 
            {
                Console.WriteLine("Exception detected!");
            }
            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }

        private static void FailProcess() 
        {
            Console.WriteLine("How do you want to crush your program?(select parameter from 1 to 13)");
            Console.Write(
                "1 - DivideByZero" + "\n" + 
                "2 - IndexOutOfRange" + "\n" +
                "3 - Argument" + "\n" +
                "4 - ArgumentNull" + "\n" +
                "5 - FileNotFound" + "\n" +
                "6 - Format" + "\n" +
                "7 - KeyNotFound" + "\n" +
                "8 - NotSupported" + "\n" +
                "9 - NullReference" + "\n" +
                "10 - Overflow" + "\n" +
                "11 - OutOfMemory" + "\n" +
                "12 - StackOverflow" + "\n" +
                "13 - Timeout" + "\n" +
                "14 - InvalidCast" + "\n"
                );
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    /*int a = 5;
                    int b = a / 0;
                    break;*/
                    throw new DivideByZeroException();
                case 2:
                    /*int[] nums = new int[5] { 1, 2, 3, 4, 5};
                    Console.WriteLine(nums[5]);
                    break;*/
                    throw new IndexOutOfRangeException();
                case 3:
                    throw new ArgumentException();
                case 4:
                    /*var dictionary = new Dictionary<string, int>();
                    int value = dictionary[null];
                    break;*/
                    throw new ArgumentNullException();
                case 5:
                    throw new FileNotFoundException();
                case 6:
                    /*int a = int.Parse("ab");
                    break;*/
                    throw new ArgumentException();
                case 7:
                    throw new KeyNotFoundException();
                case 8:
                    throw new NotSupportedException();
                case 9:
                    /*List<String> names = new List<String>();
                    if (true)
                    {
                        names = null;
                    }
                    names.Add("abc");
                    break;*/
                    throw new NullReferenceException();
                case 10:
                    /*string str = "757657657657657";
                    int res = int.Parse(str);
                    break;*/
                    throw new OverflowException();
                case 11:
                    //2 bytes * 2147483647 = 4294967294 bytes = ~4 gigabytes
                    /*string value = new string('a', int.MaxValue);
                    break;*/
                    throw new OutOfMemoryException();
                case 12:
                    /*recursion();
                    break;*/
                    throw new StackOverflowException();
                case 13:
                    throw new TimeoutException();
                case 14:
                    throw new InvalidCastException();
                default:
                    if (x < 1 || x > 14)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
            }
        }

        private static void recursion()
        {
            recursion();
        }
    }
}
