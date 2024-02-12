using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[6];
            //Заполнение одномерного массива с клавиатуры. Задание 1.
            Console.Write("Введите размер массива :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите элемент {i+1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив:");
            foreach (int iteam in array)
            {
                Console.Write(iteam + " ");




            }
            //2) Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры. 
            _ = new int[10];
            //3) Заполнить одномерный массив соответствующими индексами (по формуле) и вывести с использованием цикла foreach.
            _ = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            //4) Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
            Random rnd = new Random();
            _ = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
















        }

    }
}

