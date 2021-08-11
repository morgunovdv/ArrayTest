using System;

namespace ArrayTest
{
    class Program
    {
        static void RemoveAt(ref int[] array, int index, int count)
        {

            int[] newArray = new int[array.Length - count];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }


        static void oddArray(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                    RemoveAt(ref array, i, count);
                }

                Console.Write(array[i] + " ");

            }

        }

            static void Main(string[] args)
            {
                Random randomLen = new Random();
                int arrayLen = randomLen.Next(10, 21);
                Random ramdomNumbers = new Random();

                int[] array = new int[arrayLen];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = ramdomNumbers.Next(1, 101);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine("\n ==================================================");
                oddArray(ref array);
                Console.ReadKey();
            }
        
    }
}
