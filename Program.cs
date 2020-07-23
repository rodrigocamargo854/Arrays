using System;

namespace arrays
{
    class Program
    {

        static void Exercise1opcional()
        {
            //versão com inserção automatica dos arrays
            var arraysA = new int[15];
            var arraysB = new int[15];
            var arraysC = new int[15];

            Random randNum = new Random();

            for (int i = 0; i < arraysA.Length; i++)
            {
                arraysA[i] = randNum.Next(1, 25);
                arraysB[i] = randNum.Next(1, 25);
            }


            for (int b = 0; b < arraysC.Length; b++)
            {
                arraysC[b] = arraysA[b] - arraysB[b];
            }

            for (int c = 0; c < arraysC.Length; c++)
            {
                Console.WriteLine(arraysC[c]);
            }

        }

        static void Exercise1()
        {
            //versão com inserção automatica dos arrays
            var arraysA = new int[15];
            var arraysB = new int[15];
            var arraysC = new int[15];

            Random randNum = new Random();

            for (int i = 0; i < arraysA.Length; i++)
            {
                Console.WriteLine("Number to A: ");
                arraysA[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Number too B: ");
                arraysB[i] = int.Parse(Console.ReadLine());
            }

            for (int b = 0; b < arraysC.Length; b++)
            {
                arraysC[b] = arraysA[b] - arraysB[b];
            }

            for (int c = 0; c < arraysC.Length; c++)
            {
                Console.WriteLine(arraysC[c]);
            }

        }

        static void Exercise2()
        {
            var newArray = new int[10];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"{i}º number:  ");
                newArray[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            for (int a = newArray.Length; a > 0; a--)
            {
                Console.WriteLine($"{a}º number:  ");
            }


        }
        static void Main(string[] args)
        {
            Exercise2();

        }
    }
}