using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8.Homework
{
    class SquaredArray
    {
        private int[] array;

        public SquaredArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Индекс вне диапазона массива");
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value * value;
                }
                else
                {
                    Console.WriteLine("Индекс вне диапазона массива");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SquaredArray myArray = new SquaredArray(5);

            // 通过索引器设置值
            myArray[0] = 2;
            myArray[1] = 3;
            myArray[2] = 4;
            myArray[3] = 5;
            myArray[4] = 6;

            // 通过索引器获取值并输出到控制台
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Элемент {i}: {myArray[i]}");
            }
        }
    }
}
