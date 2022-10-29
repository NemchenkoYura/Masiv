using System;

namespace Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int a = int.Parse(Console.ReadLine());

            int[] b = new int[a];

            for (int i = 0; i <b.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t ");
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");

            for (int i = 0; i < b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
