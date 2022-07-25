using System;

namespace CS27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            int userInput = 0;

            Console.Write("Введите число на сколько раз сдвинуть массив: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                for (int t = 0; t < array.Length - 1; t++)
                {
                    int value = array[t];
                    array[t] = array[t + 1];
                    array[t + 1] = value;
                }
            }

            Console.WriteLine($"Cдвиг в лево на {userInput} элемент(ов)");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}