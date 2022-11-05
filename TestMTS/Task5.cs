using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Программа выводит на экран строку «Муха», а затем продолжает выполнять остальной код. Реализуйте
//метод TransformToElephant так, чтобы программа выводила на экран строку «Слон», а затем продолжала
//выполнять остальной код, не выводя перед этим на экран строку «Муха».

namespace TestMTS
{
    public static class Task5
    {
        public static void Execute()
        {
            TransformToElephant();
            Console.WriteLine("Fly");
        }

        private static void TransformToElephant()
        {
            Console.WriteLine("Elephant");
            //можно добавлять новые методы.
            //код будет продолжаться до тех пор, пока не закончатся вызываемые методы.
            Console.WriteLine("There is no fly!");
            Console.ReadLine();
            //закрываем программу
            Environment.Exit(0);
        }
    }
}
