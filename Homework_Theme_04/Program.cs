using System;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Задание 1.
            //Random random = new Random();
            int[,] arr = new int[12, 4];
            int[] loss = new int[12];
            int profit = 0;
            string mounth = "";
            Console.WriteLine($"{"Месяц",5} {"Доход, тыс. руб.",15} {"Расход, тыс. руб.",15} {"Прибыль, тыс. руб.",15}");

            for (int i = 0; i < 12; i++)
            {
                arr[i, 0] = i + 1;//заполняем номер месяца.
                Console.Write($"Доходы за {i + 1} месяц:");
                arr[i, 1] = Check();//заполняем доходы за месяц
                Console.Write($"Расходы за {i + 1} месяц:");
                arr[i, 2] = Check();//заполняем расходы за месяц

                //arr[i, 1] = random.Next(1, 5) * 10;
                //arr[i, 2] = random.Next(1, 5) * 10;

                arr[i, 3] = arr[i, 1] - arr[i, 2];//подсчет прибыли
                loss[i] = arr[i, 3];
                Console.WriteLine($"{arr[i, 0],5} {arr[i, 1],15} {arr[i, 2],15} {arr[i, 3],15}");
            }
            Array.Sort(loss);

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (arr[i, 3] > 0 && j == 0)
                    {
                        profit++;
                    }
                    if (arr[i, 3] == loss[j])
                    {
                        if (String.IsNullOrWhiteSpace(mounth))
                        {
                            mounth = (i + 1).ToString();
                        }
                        else
                        {
                            mounth = mounth + ", " + (i + 1).ToString();
                        }
                    }
                }
            }
            Console.WriteLine($"Худшая прибыль в месяцах: {mounth}");

            Console.WriteLine($"Месяцев с положительной прибылью: {profit}");
            Console.Read();

            Console.Write("Введите количество строк : ");
            */
            /*
            //Задание 2.
            int n = int.Parse(Console.ReadLine());
            int[][] tr = new int[n][];
            // первая строка
            tr[0] = new int[] { 1 };

            for (int i = 1; i < tr.Length; i++)
            {
                tr[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        tr[i][j] = 1;
                    else
                    {
                        tr[i][j] = tr[i - 1][j - 1] + tr[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < tr.Length; i++)
            {
                for (int j = 0; j < tr[i].Length; j++)
                {
                    Console.Write("{0,-3} ", tr[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */

            //задание 3.1
            /*
            int a = 0;
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0;j<arr.GetLength(1); j++)
                {
                    a++;
                    arr[i, j] = a;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("ВВедите число:");
            int operand = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= operand;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            //задание 3.2 (Сложение)
            /*
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];

            int a = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a++;
                    arr[i, j] = a;
                    arr1[i, j] = a;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "+" + "\n");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "=" + "\n"); 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] += arr[i, j];
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            //Задание 3.2 (вычитание)
            /*
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];

            int a = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a++;
                    arr[i, j] = a;
                    arr1[i, j] = a;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "-" + "\n");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "=" + "\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] -= arr[i, j];
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            //Задание 3.3
            
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];

            int a = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a++;
                    arr[i, j] = a;
                    arr1[i, j] = a;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "*" + "\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + "=" + "\n");
            int[,] arr2 = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for(int k=0;k<arr1.GetLength(0);k++)
                    {
                        arr2[i,j] += arr[i, k] * arr1[k, j];
                    }
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            /*
            int Check()
            {
                int x;
                while (true)
                {
                    while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("нужно вести число!");
                    {
                        break;
                    }
                }
                return x;
            }
            */
        }

    }
}

