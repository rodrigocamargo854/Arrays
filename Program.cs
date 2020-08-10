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

            public Arrays(double arrayA, double arrayB)
            {
                Array1 = arrayA;
                Array2 = arrayB;
            }
            public Arrays(double arrayA)
            {
                Array1 = arrayA;

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
                    Console.WriteLine($"number for A:  ");
                    double arraysA = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"number for B:  ");
                    double arraysB = Double.Parse(Console.ReadLine());

                    vect[i] = new Arrays(arraysA, arraysB);
                }

                Console.WriteLine("Vetor C");

                for (int i = 0; i < c; i++)
                {
                    arraysF[i] = vect[i].Array1 - vect[i].Array2;
                    Console.Write($"{arraysF[i]} ");

                }

            }

            // 2-Ler um array com 10 inteiros e mostrar os números na 
            // ordem direta e inversa a que foram lidos
            static void Exercise2()
            {
                var c = 10;
                var newArray = new int[c];

                for (int i = 0; i < c; i++)
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
            // 3-Leia 10 elementos e armazene em um array A. 
            // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a 
            // mensagem: “O número existe no array” , caso contrário “Número inexistente”.       
            static void Exercise3()
            {
                var c = 5;
                Arrays[] vect = new Arrays[c];
                var newArrays = new double[c];


                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{i}º number:  ");
                    double nb = double.Parse(Console.ReadLine());
                    vect[i] = new Arrays(nb);
                    Console.Clear();
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

            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique
            //  se os mesmos são iguais ou diferentes.
            static void Exercise4()
            {
                var c = 4;
                Arrays[] vect = new Arrays[c];
                var newArrays = new double[c];

                for (int i = 1; i < c; i++)
                {
                    Console.Write($"{i}º number for A:  ");
                    double nbA = double.Parse(Console.ReadLine());
                    Console.Write($"{i}º number for B:  ");
                    double nbB = double.Parse(Console.ReadLine());

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
            //  5-Leia um array A com 15 elementos, 
            //  e calcule a média aritmética dos 
            //  mesmos, em seguida, diga quantos
            //   dos elementos lidos estão abaixo, acima e na média.
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
                    arraysD[i] = int.Parse(Console.ReadLine());
                    media += arraysD[i];
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

            //metodo auxiliar bolha para o exercicio 6

            // 6-Leia um array 
            // A com 12 elementos.
            //  Após sua leitura, 
            //  colocar os seus elementos em
            // ordem crescente.
            //  Depois ler um array
            //   B também com doze elementos,
            //    colocar os elementos de B em 
            //    ordem decrescente. Construir 
            //    um array C, onde cada elemento 
            //    de C é a soma do elemento correspondente
            //     de A com b. Colocar em ordem crescente a matriz
            // C e apresentar os seus valores.


            static void Exercise6()
            {
                var c = 12;
                var arraysG = new int[c];
                var arraysT = new int[c];
                var arraysC = new int[c];

                Console.WriteLine("Coletanto matriz A e colocando em ordem crescente");

                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine("Números matriz A : ");
                    arraysG[i] = int.Parse(Console.ReadLine());
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
                //1.  Dada uma sequencia de n números, imprimi-la 
                // na ordem inversa à da leitura. 

                var arraysA = new int[5] { 5, 4, 6, 3, 2 };

                for (int j = arraysA.Length - 1; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
            }


            //-------------Lista 2 Arrays - exercicios 1
            static void Lista2_exercise1()
            {
                //Popule dois vetores com 10 valores cada. 
                //Após esta operação, troque o conteúdo dos vetores.
                var c = 4;
                Arrays[] vect = new Arrays[c];
                var tempA = new double[c];
                var tempB = new double[c];

                for (int i = 1; i < c; i++)
                {
                    Console.WriteLine("Números para o vetor A : ");
                    double valor1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Números para o vetor B : ");
                    double valor2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    vect[i] = new Arrays(valor1, valor2);

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
                            arraysIguais[j] = arraysA[j];
                            repetidos++;
                        }
                    }
                }

                string repeat = " Este vetor ";
                repeat += repetidos != 0 ? " possui números repetidos" : " Não possui números repetidos";
                Console.WriteLine(repeat);
            }


            //-------------Lista 2 Arrays - exercicios 3

            static void Lista2_Exercise3()
            {
                List<string> sex = new List<string>();
                List<string> answers = new List<string>();
                int yesCount = 0;
                int noCount = 0;
                double malePerc = 0.0;
                double femPerc = 0.0;
                double countM = 0;
                double countF = 0;
                double percMale = 0.0;
                double percFemale = 0.0;

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("Sexo: ");
                    sex.Add(Console.ReadLine());

                    Console.WriteLine("Answers: ");
                    answers.Add(Console.ReadLine());
                }

                foreach (string i in sex)
                {
                    if (i == "Male" || i == "male")
                    {
                        countM++;
                    }
                    else if (i == "female" || i == "Female")
                    {
                        countF++;
                    }
                }

                foreach (string i in answers)
                {
                    if (i == "yes" || i == "Yes")
                    {
                        yesCount++;
                    }
                    else if (i == "No" || i == "no")
                    {
                        noCount++;
                    }
                }

                percMale = (countM * 100) / 10.0;
                percFemale = (countF * 100) / 10.0;

                Console.WriteLine($"Number of females {countF} , number of males {countM} ");
                Console.WriteLine($"Number of people who answered no:  {noCount} ");
                Console.WriteLine($"Number of people who answered yes:  {yesCount}");
                Console.WriteLine($"Percentage of female  who answered yes  {percFemale}%");
                Console.WriteLine($"Percentage of males who answered yes  {percMale}%");
            }


            //-------------Lista 2 Arrays - exercicios 4

            static void Lista2_Exercise4()
            {
                var j = 5;
                var arraysA = new int[j];
                int sumimp = 0;

                Console.WriteLine("Digite 5 números para preencher o vetor: ");

                for (int i = 0; i < j; i++)
                {
                    arraysA[i] = int.Parse(Console.ReadLine());
                }

                for (int a = 0; a < arraysA.Length; a++)
                {
                    if (arraysA[a] % 2 != 0)
                    {
                        sumimp += arraysA[a];
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
                int sumimp = 0;
                int numArray = 0;

                Console.WriteLine("Digite 10 números para preencher o vetor: ");

                for (int i = 1; i < arraysA.Length; i++)
                {
                    numArray = int.Parse(Console.ReadLine());
                    if (numArray > 0)
                    {
                        arraysA[i] = numArray;
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
                var arraysA = new int[10];
                var arraysC = new int[10];
                List<int> repeats = new List<int>();
                int numb = 0;

                for (int a = 0; a < arraysA.Length; a++)
                {
                    Console.WriteLine("Digit: ");
                    arraysA[a] = int.Parse(Console.ReadLine());
                    if (arraysA[a] == a)
                    {
                        numb++;
                        repeats.Add(arraysA[a]);
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
                Lista2_exercise1() ;
             }
        }
    }
}






