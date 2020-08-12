using System;
using System.Collections.Generic;
namespace arrays
{
    class Program
    {
        //-------------metodo auxiliar (bubble)
        public static void troca(int[] g, int first)
        {
            int temp;

            temp = g[first];
            g[first] = g[first + 1];
            g[first + 1] = temp;
        }

        class Arrays
        {
            public double Array1 { get; set; }
            public double Array2 { get; set; }

            public double Array3 { get; set; }

            public string Array4 { get; set; }
            public string Array5 { get; set; }


            public Arrays(double arrayA, double arrayB)
            {
                Array1 = arrayA;
                Array2 = arrayB;
            }
            public Arrays(double arrayA)
            {
                Array1 = arrayA;

            }

            public Arrays(string arrayS, string arrayT)
            {
                Array4 = arrayS;
                Array5 = arrayT;
            }

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

                    arraysC[i] = arraysA[i] - arraysB[i];
                }

                for (int c = 0; c < arraysC.Length; c++)
                {
                    Console.WriteLine(arraysC[c]);
                }
            }

            static void Exercise1()
            {
                //1-Leia dois arrays A e B com 15 elementos. Construir um array C, onde
                //cada elemento de C é a subtração do elemento correspondente de A com B.
                //versão com inserção automatica dos arrays

                var c = 2;
                Arrays[] vect = new Arrays[c];
                var arraysF = new double[c];

                for (int i = 0; i < c; i++)
                {

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine($"number for A:  ");
                            double arraysA = Double.Parse(Console.ReadLine());
                            Console.WriteLine($"number for B:  ");
                            double arraysB = Double.Parse(Console.ReadLine());

                            vect[i] = new Arrays(arraysA, arraysB);
                            break;

                        }
                        catch (System.Exception)
                        {

                            Console.WriteLine("Digite somente números ");
                        }


                    }

                }

                Console.WriteLine("Vetor C");

                for (int i = 0; i < c; i++)
                {
                    arraysF[i] = vect[i].Array1 - vect[i].Array2;
                    Console.Write($"{arraysF[i]} ");

                }

            }


            static void Exercise2()
            {
                var c = 3;
                var newArray = new int[c];

                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine($"number:  ");

                    while (true)
                    {
                        try
                        {
                            newArray[i] = int.Parse(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }
                }

                Console.WriteLine("Número em ordem direta");
                Console.ReadKey();
                Console.Clear();

                foreach (var x in newArray)
                {
                    Console.Write($"{x} ");
                }

                Console.WriteLine("Números em ordem inversa");
                Console.ReadKey();
                Console.Clear();

                for (int a = c; a > 0; a--)
                {
                    Console.Write($"{newArray[a]} ");
                }
            }

            static void Exercise3()
            {
                var c = 5;
                Arrays[] vect = new Arrays[c];
                var newArrays = new double[c];

                for (int i = 1; i < c; i++)
                {

                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i}º number:  ");
                            double nb = double.Parse(Console.ReadLine());
                            vect[i] = new Arrays(nb);
                            Console.Clear();
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }

                }

                Console.WriteLine("Digite um número: ");
                int number = int.Parse(Console.ReadLine());
                int temp = 0;

                for (int i = 1; i < c; i++)
                {
                    if (number == vect[i].Array1)
                    {
                        temp = number;
                    }
                }

                string resultado = "este número  ";
                resultado += temp != 0 ? "  está no array." : "  não está no array.";
                Console.WriteLine(resultado);
            }

            static void Exercise4()
            {
                double nbA = 0.0;
                double nbB = 0.0;
                var c = 4;
                Arrays[] vect = new Arrays[c];
                var newArrays = new double[c];

                for (int i = 1; i < c; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i}º number for A:  ");
                            nbA = double.Parse(Console.ReadLine());
                            Console.Write($"{i}º number for B:  ");
                            nbB = double.Parse(Console.ReadLine());
                            break;
                        }

                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }

                    vect[i] = new Arrays(nbA, nbB);
                    Console.Clear();
                }

                for (int b = 1; b < c; b++)
                {
                    string resultado = "Os números ";
                    resultado += vect[b].Array1 == vect[b].Array2 ? $"{vect[b].Array1} é igual a {vect[b].Array2}" : $"{vect[b].Array1} não é igual a {vect[b].Array2}";
                    Console.WriteLine(resultado);
                }

            }

            static void Exercise5()
            {
                int value = 15;
                var arraysD = new int[value];

                double media = 0.0;
                var smaller = 0;
                var bigger = 0;

                //populando array
                for (int i = 0; i < value; i++)
                {
                    Console.WriteLine("Number to D: ");

                    while (true)
                    {
                        try
                        {
                            arraysD[i] = int.Parse(Console.ReadLine());
                            media += arraysD[i];
                        }

                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }
                }

                for (int b = 0; b < arraysD.Length; b++)
                {
                    if (arraysD[b] < media / value)
                    {
                        smaller++;
                    }
                    else if (arraysD[b] > media / value)
                    {
                        bigger++;
                    }
                }

                Console.WriteLine($" The media is {media / value}");
                Console.ReadKey();

                Console.WriteLine($"{smaller} numbers are below average");
                Console.ReadKey();

                Console.WriteLine($"{bigger} numbers are above average");
                Console.ReadKey();

            }



            static void Exercise6()
            {
                var c = 12;
                var arraysG = new int[c];
                var arraysT = new int[c];
                var arraysC = new int[c];

                Console.WriteLine("Coletanto matriz A e colocando em ordem crescente");

                for (int i = 0; i < c; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Números matriz A : ");
                            arraysG[i] = int.Parse(Console.ReadLine());


                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }
                }

                //Colocando matrix G em ordem crescente
                for (int i = 1; i < c; i++)
                {
                    //colocamos proteção para não passar do limite do array.length
                    for (int j = 0; j < c - 1; j++)
                    {
                        if (arraysG[j] > arraysG[j + 1])
                        {
                            troca(arraysG, j);
                        }
                    }
                }

                for (int j = 0; j < c; j++)
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
                for (int i = 1; i < c; i++)
                {
                    for (int j = 0; j < c - 1; j++)
                    {
                        if (arraysT[j] < arraysT[j + 1])
                        {
                            troca(arraysT, j);
                        }
                    }
                }

                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{ arraysT[j]} ");
                }
                Console.Clear();
                Console.ReadKey();

                //Matriz C criada para receber a soma dos elementos de T e G

                for (int j = 0; j < c; j++)
                {
                    arraysC[j] = arraysG[j] - arraysT[j];
                }

                for (int i = 1; i < c; i++)
                {
                    for (int j = 0; j < c - 1; j++)
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

            static void Exercise7()
            {


                var arraysA = new int[5] { 5, 4, 6, 3, 2 };

                for (int j = arraysA.Length - 1; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
            }


            //-------------Lista 2 Arrays - exercicios 1
            static void Lista2_exercise1()
            {

                var c = 4;
                Arrays[] vect = new Arrays[c];
                var tempA = new double[c];
                var tempB = new double[c];

                for (int i = 1; i < c; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Números para o vetor A : ");
                            double valor1 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Números para o vetor B : ");
                            double valor2 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            vect[i] = new Arrays(valor1, valor2);
                            break;
                        }

                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }

                }

                Console.WriteLine("Vetor A");
                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{vect[i].Array1} ");
                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Vetor B");
                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{vect[i].Array2} ");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Trocando os valores");

                for (int i = 1; i < c; i++)
                {
                    tempA[i] = vect[i].Array1;
                    vect[i].Array1 = vect[i].Array2;
                    vect[i].Array2 = tempA[i];
                }


                Console.WriteLine("Vetor A");
                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{vect[i].Array1} ");
                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Vetor B");
                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{vect[i].Array2} ");
                }
                Console.ReadKey();
                Console.Clear();
            }



            //-------------Lista 2 Arrays - exercicios 2


            static void Lista2_Exercise2()
            {
                var arraysA = new int[11] { 1, 2, 5, 0, 111, 87, 6, 8, 9, 117, 11 };
                var arraysIguais = new int[11];

                var repetidos = 0;

                for (int i = 1; i < arraysA.Length; i++)
                {
                    for (int j = 0; j < arraysA.Length - 1; j++)
                    {
                        if (arraysA[j] == arraysA[j + 1])
                        {
                            repetidos++;
                        }
                    }
                }
                string repeat = " Este vetor ";
                repeat += repetidos != 0 ? " possui números repetidos" : " Não possui números repetidos";
            }

            //-------------Lista 2 Arrays - exercicios 3



            static void Lista2_Exercise3()
            {
                var n = 2;
                Arrays[] vect = new Arrays[n];
                int yesCount = 0;
                int noCount = 0;
                double countM = 0;
                double countF = 0;

                for (int i = 0; i < n; i++)

                {

                    Console.WriteLine("Sexo: ");
                    string sex = (Console.ReadLine());
                    Console.WriteLine("Resposta: ");
                    string resp = (Console.ReadLine());
                    vect[i] = new Arrays(sex, resp);

                    bool verifyM = vect[i].Array4 == "masculino";
                    bool verifyF = vect[i].Array4 == "feminino";
                    bool verifyAyes = vect[i].Array5 == "sim";
                    bool verifyAno = vect[i].Array5 == "não";

                    if (verifyM)
                    {
                        countM++;
                    }
                    if (verifyF)
                    {
                        countF++;
                    }
                    if (verifyAyes)
                    {
                        yesCount++;
                    }
                    if (verifyAno)
                    {
                        noCount++;
                    }
                }

                Console.WriteLine($"Número de pessoas que disseram sim:  {yesCount}");
                Console.WriteLine($"Número de pessoas que disseram não  {noCount} ");
                var man = " Porcentagem de homens  ";
                var women = " Porcentagem de mulheres  ";
                women += countF != 0 ? $" que disseram sim  {(countF * 100) / yesCount}%" : "Sem valores ";
                Console.WriteLine(women);
                man += countM != 0 ? $" que disseram não  {(countM * 100) / noCount}%" : "Sem valores ";
                Console.WriteLine(man);

            }


            //-------------Lista 2 Arrays - exercicios 4

            static void Lista2_Exercise4()
            {
                var j = 5;
                Arrays[] vect = new Arrays[j];
                double sumimp = 0;

                Console.WriteLine("Digite 5 números para preencher o vetor: ");

                for (int i = 0; i < j; i++)
                {
                    while (true)
                    {
                        try
                        {
                            double elem = double.Parse(Console.ReadLine());
                            vect[i] = new Arrays(elem);
                            break;

                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Digite um número por favor");
                        }
                    }

                }

                for (int a = 0; a < j; a++)
                {
                    if (vect[a].Array1 % 2 != 0)
                    {
                        sumimp += vect[a].Array1;
                    }
                }

                Console.Write($" A soma dos números ímpares é : {sumimp}");
            }

            //-------------Lista 2 Arrays - exercicios 5

            static void Lista2_Exercise5()
            {
                var arraysA = new int[10] { 1, 2, -5, 0, -111, -87, 6, 8, 9, 117 };
                int sumPos = 0;

                for (int a = 0; a < arraysA.Length; a++)
                {
                    if (arraysA[a] > 0)
                    {
                        sumPos++;
                    }
                }

                Console.Write($" A soma dos números positivos  é : {sumPos}");
            }



            //-------------Lista 2 Arrays - exercicios 6

            static void Lista2_Exercise6()
            {
                var arraysA = new int[11];
                int numArray = 0;
                Console.WriteLine("Digite 10 números para preencher o vetor: ");

                for (int i = 1; i < arraysA.Length; i++)
                {
                    while (true)
                    {
                        try
                        {

                            numArray = int.Parse(Console.ReadLine());
                            if (numArray > 0)
                            {
                                arraysA[i] = numArray;
                            }
                            break;

                        }
                        catch (System.Exception)
                        {

                            Console.WriteLine("Digite um número por favor! ");
                        }
                    }

                }

                for (int i = 1; i < arraysA.Length; i++)
                {
                    for (int j = 0; j < arraysA.Length - 1; j++)
                    {
                        if (arraysA[j] > arraysA[j + 1])
                        {
                            troca(arraysA, j);
                        }
                    }
                }

                Console.Write($" O maior número deste vetor é : {arraysA[10]}");
            }


            //-------------Lista 2 Arrays - exercicios 7

            static void Lista2_Exercise7()
            {
                var c = 4;
                Arrays[] vect = new Arrays[c];
                // var arraysA = new int[10];
                // var arraysC = new int[10];
                List<double> repeats = new List<double>();
                int numb = 0;

                for (int a = 0; a < c; a++)
                {
                    Console.WriteLine("Digit: ");
                    double num = double.Parse(Console.ReadLine());
                    vect[a] = new Arrays(num);

                    if (vect[a].Array1 == a)
                    {
                        numb++;
                        repeats.Add(vect[a].Array1);
                    }
                }

                if (numb == 0)
                {
                    Console.WriteLine("THERE ARE NO NUMBERS IN YOUR INDEX");
                }

                else
                {
                    Console.WriteLine($"The numbers of digits repeat in the same position of your index is { numb} ");
                    Console.Write($"The numbers are:  ");

                    foreach (int i in repeats)
                    {

                        Console.Write($" {repeats[i]}");

                    }
                }

            }

            //-------------Lista 2 Arrays - exercicios 8


            static void Lista2_Exercise8()
            {
                string[] letters = new string[10];
                string[] vogals = new string[5] { "a", "e", "i", "o", "u" };
                var countR = 0;
                // List<int> repeats = new List<int>();
                //pupula o vetor 
                for (var a = 0; a < 10; a++)
                {
                    Console.WriteLine("Letter: ");
                    letters[a] = Console.ReadLine();
                }

                foreach (var i in letters)
                {
                    foreach (var a in vogals)
                    {
                        if (i == a)
                        {
                            countR++;
                        }
                    }
                }
                Console.WriteLine($"The number of vogals in this arrays is {countR}");
            }

            //-------------Lista 2 Arrays - exercicios 9
            static void Lista2_Exercices9()
            {
                string[] letters = new string[10];
                List<string> oddSum = new List<string>();

                var countR = 0;

                for (var a = 0; a < letters.Length; a++)
                {
                    Console.WriteLine("Letter: ");
                    letters[a] = Console.ReadLine();
                }

                for (int i = 0; i < letters.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddSum.Add(letters[i]);
                    }
                }

                Console.WriteLine($"The word formade with the odds index:  ");
                foreach (var a in oddSum)
                {
                    Console.Write($"{a}");
                }

            }

            static void Main(string[] args)
            {
                Lista2_Exercise3();
            }
        }
    }
}






