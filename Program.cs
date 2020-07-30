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

            for (int i = 1; i < newArrays.Length; i++)
            {
                Console.WriteLine($"{i}º number:  ");
                newArrays[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int n = 1; n < newArrays.Length; n++)
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

            var arraysD = new int[10];
            var arraysE = new int[10];
            var arraysF = new int[10];

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
                    Console.WriteLine($"{arraysE[b]} é igual a {arraysF[b]}");
                }

                else
                {
                    Console.WriteLine($"{arraysE[b]} não é igual a {arraysF[b]}");
                }
            }
        }

        static void Exercise5()
        {
            var arraysD = new int[4];

            double media = 0.0;
            var smaller = 0;
            var bigger = 0;

            for (int i = 0; i < arraysD.Length; i++)
            {
                Console.WriteLine("Number to D: ");
                arraysD[i] = int.Parse(Console.ReadLine());
            }
            for (int b = 0; b < arraysD.Length; b++)
            {
                media += arraysD[b];
            }

            for (int b = 0; b < arraysD.Length; b++)
            {
                if (arraysD[b] < media / arraysD.Length)
                {
                    smaller++;
                }
                else if (arraysD[b] > media / arraysD.Length)
                {
                    bigger++;
                }
            }

            Console.WriteLine($" The media is {media / arraysD.Length}");
            Console.ReadKey();

            Console.WriteLine($"{smaller} numbers are below average");
            Console.ReadKey();

            Console.WriteLine($"{bigger} numbers are above average");
            Console.ReadKey();

        }

        //metodo auxiliar bolha para o exercicio 6
        public static void troca(int[] g, int first)
        {
            int temp;

            temp = g[first];
            g[first] = g[first + 1];
            g[first + 1] = temp;
        }
        static void Exercise6()
        {
            // var arraysT = new int[12];
            var arraysG = new int[12];
            var arraysT = new int[12];
            var arraysC = new int[12];

            Console.WriteLine("Coletanto matriz A e colocando em ordem crescente");

            for (int i = 0; i < arraysG.Length; i++)
            {
                Console.WriteLine("Números matriz A : ");
                arraysG[i] = int.Parse(Console.ReadLine());
            }

            //Colocando matrix G em ordem crescente
            for (int i = 1; i < arraysG.Length; i++)
            {
                //colocamos proteção para não passar do limite do array.length
                for (int j = 0; j < arraysG.Length - 1; j++)
                {
                    if (arraysG[j] > arraysG[j + 1])
                    {
                        troca(arraysG, j);
                    }
                }
            }

            for (int j = 0; j < arraysG.Length; j++)
            {
                Console.Write($"{ arraysG[j]} ");
            }

            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("Coletanto matriz B e colocando em ordem decrescente");

            for (int i = 0; i < arraysG.Length; i++)
            {
                Console.WriteLine("Números matriz B : ");
                arraysT[i] = int.Parse(Console.ReadLine());
            }

            //Colocando matrix T em ordem crescente
            for (int i = 1; i < arraysT.Length; i++)
            {
                for (int j = 0; j < arraysT.Length - 1; j++)
                {
                    if (arraysT[j] < arraysT[j + 1])
                    {
                        troca(arraysT, j);
                    }
                }
            }

            for (int j = 0; j < arraysT.Length; j++)
            {
                Console.Write($"{ arraysT[j]} ");
            }
            Console.Clear();
            Console.ReadKey();

            //Matriz C criada para receber a soma dos elementos de T e G

            for (int j = 0; j < arraysT.Length; j++)
            {
                arraysC[j] = arraysG[j] - arraysT[j];
            }

            for (int i = 1; i < arraysG.Length; i++)
            {
                for (int j = 0; j < arraysG.Length - 1; j++)
                {
                    if (arraysC[j] > arraysC[j + 1])
                    {
                        troca(arraysG, j);
                    }
                }
            }
            Console.Write("Matriz C em ordem Crescente");
            Console.ReadKey();

            for (int j = 0; j < arraysC.Length; j++)
            {
                Console.Write($"{arraysC[j] } ");
            }
        }

        //Outra lista aleatória
        static void Exercise7()
        {
            //1.  Dada uma sequencia de n números, imprimi-la 
            // na ordem inversa à da leitura. 

            var arraysA = new int[11];

            for (int j = arraysA.Length - 1; j > 0; j--)
            {
                Console.WriteLine(j);
            }
        }
        //***************************************************************************************
        static void Lista2_exercise1()
        {
            //Popule dois vetores com 10 valores cada. 
            //Após esta operação, troque o conteúdo dos vetores.
            var arraysA = new int[11];
            var arraysB = new int[11];
            var tempA = new int[11];
            var tempB = new int[11];



            for (int i = 1; i < arraysA.Length; i++)
            {
                Console.WriteLine("Números para o vetor A : ");
                arraysA[i] = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Números para o vetor B : ");
                arraysB[i] = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("Vetor A");
            for (int i = 1; i < arraysA.Length; i++)
            {
                Console.Write($"{arraysA[i]} ");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vetor B");
            for (int i = 1; i < arraysB.Length; i++)
            {
                Console.Write($"{arraysB[i]} ");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Trocando os valores");

            for (int i = 1; i < arraysA.Length; i++)
            {
                tempB[i] = arraysB[i];
                tempA[i] = arraysA[i];

                arraysB[i] = tempA[i];
                arraysA[i] = tempB[i];
            }

            Console.WriteLine("Vetor A");
            for (int i = 1; i < arraysA.Length; i++)
            {
                Console.Write($"{arraysA[i]} ");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vetor B");
            for (int i = 1; i < arraysB.Length; i++)
            {
                Console.Write($"{arraysB[i]} ");
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Lista2_Exercise2()
        {
            //Dado um vetor qualquer com 10 números, 
            //faça um programa que informa se 
            //há ou não números repetidos nesse vetor.

            var arraysA = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var repetidos = 0;

            for (int j = arraysA.Length; j > 0; j++)
            {
                for (int x = 0; x < arraysA.Length - 1; x++)
                {
                    if (arraysA[x] == arraysA[x + 1])
                    {
                        repetidos++;
                    }
                }
            }

            if (repetidos != 0)
            {
                Console.WriteLine($"Há {repetidos} numeros repetidos neste vetor");
            }
            else

            {
                Console.WriteLine("Não há numeros repetidos neste vetor");
            }
        }
        static void Main(string[] args)
        {
            Lista2_Exercise2();
        }
    }
}




