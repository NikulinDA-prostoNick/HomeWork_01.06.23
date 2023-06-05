// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }

// void printm(int[,] array)
// {
//     int i, j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// mas(m, n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);

// Процедура сортировки элементов в строке двумерного массива по убыванию
// void uporyadok(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
// {
//     if (array[i, k] < array[i, k + 1])
//     {
//         int temp = array[i, k + 1];
//         array[i, k + 1] = array[i, k];
//         array[i, k] = temp;
//     }
// }
// }
// }
// }

// uporyadok(randomArray);
// Console.WriteLine("\nОтсортированный массив: ");
// printm(randomArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }

// void printm(int[,] array)
// {
//     int i, j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// mas(m, n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);

// Функция, считающая сумму элементов в строке
// int SumLine(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
//     if (sum > SumLine(randomArray, i))
//     {
//         sum = SumLine(randomArray, i);
//         minSum = i + 1;
//     }
// }

// Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }

// void printm(int[,] array)
// {
//     int i, j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// mas(m, n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);

// Функция, считающая сумму элементов в строке
// int SumLine(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
//     if (sum > SumLine(randomArray, i))
//     {
//         sum = SumLine(randomArray, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// string [] stringArray = new string [m];
// void array(string [] stringArray)
// {
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//      Console.WriteLine($"Введите {i+1} элемент массива");
//      stringArray[i] = Console.ReadLine();
//   }
// }
// string [] symbol(string [] stringArray)
// {
//   int n = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     n++;
//   }
//   string [] rez = new string [n];
//   int j = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     {
//         rez[j] = stringArray[i];
//         j++;
//     }
//   }
//   return rez;
// }
// void printA(string [] stringArray)
// {
//     Console.Write("[");
//     for (int i = 0;i<stringArray.Length;i++)
//     {
//     Console.Write($"‘{stringArray[i]}’, ");
//     }
//     Console.Write("]");
// }
// array(stringArray);
// printA(symbol(stringArray));


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }

// void printm(int[,] array)
// {
//     int i, j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// mas(m, n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);

// // Функция, считающая сумму элементов в строке
// int SumLine(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
//     if (sum > SumLine(randomArray, i))
//     {
//         sum = SumLine(randomArray, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");