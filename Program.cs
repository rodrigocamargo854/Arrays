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
                Console.WriteLine($"number:  ");
                newArray[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Número em ordem direta");
            Console.ReadKey();
            Console.Clear();

            foreach (var x in newArray)
            {
                Console.Write($"{x} ");
            }

            Console.ReadKey();
            Console.WriteLine("Números em ordem inversa");
            Console.ReadKey();
            Console.Clear();

            for (int a = newArray.Length; a > 0; a--)
            {
                Console.Write($"{a} ");
            }
        }

        static void Exercise3()
        {
            var newArrays = new int[11];
            var temp = 0;
            for (int i = 1; i < newArrays.Length; i++)
            {
                Console.WriteLine($"{i}º number:  ");
                newArrays[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            foreach (int n in newArrays)
            {
                if (number == newArrays[n])
                {
                    temp = newArrays[n];
                }
            }

            if (temp != 0)
            {
                Console.WriteLine("Este número está no array");
            }
            else
            {
                Console.WriteLine("Este não está no array");
            }
        }
        static void Exercise4()
        {
            //versão com inserção automatica dos arrays
            var arraysD = new int[5];
            var arraysE = new int[5];
            var arraysF = new int[5];


            for (int i = 0; i < arraysD.Length; i++)
            {
                Console.WriteLine("Number to A: ");
                arraysE[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Number too B: ");
                arraysF[i] = int.Parse(Console.ReadLine());
            }

            for (int b = 0; b < arraysF.Length; b++)
            {
                if (arraysE[b] == arraysF[b])
                {
                  Console.WriteLine($"{arraysE[b]} é igual a {arraysF[b]}") ; 
                }

                else
                {
                    Console.WriteLine($"{arraysE[b]} não é igual a {arraysF[b]}") ; 
                }
            }
        }

        static void Main(string[] args)
        {
            Exercise4();
        }
    }
}