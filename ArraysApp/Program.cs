using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[4] { 1, 2, 3, 4 }; //равносильно int[] numbers = { 1, 2, 3, 4 }
            //                                           // первый индекс массива 0, последний 3 (0-3)
            //int n = numbers[0]; // индекс массива 0 - значение элемента массива 1
            //numbers[0] = 7; // изменим значение 1-го элемемента массива равное 7
            //Console.WriteLine(numbers[0]); // чтобы вывести много переменных использовать foreach
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);

            int[] numbers = new int[4] { 1, 2, 3, 4 }; //равносильно int[] numbers = { 1, 2, 3, 4 }
                                                       // первый индекс массива 0, последний 3 (0-3)
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            // или 
            for(int i=0; i < numbers.Length; i++) // numbers.Lengs хранит длинну массива
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
