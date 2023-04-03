/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
// 8 7,8 -7,1 9*/
// double[,] FillMatrixWithRandom(int row, int column)
// {
// double[,] array = new double[row, column];
// Random md = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = md.NextDouble()*10;
// }
// }
// return array;
// }

// void PrintMatrix(double[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} \t");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// int FindNumber(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i][j]} \t");
//     }
//     Console.WriteLine();
// }
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// Console.Write("$Введите индексы:{matrix[i][j]}");
// matrix = Convert.ToInt32(Console.ReadLine());
// FindNumber(matrix);


// /*Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// int SumMainDiagonal(int[,] matrix)
// {
// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// while(i < matrix.GetLength(0))
// {
// sum+=matrix[i,i];
// }
// }
// }
// return sum;
// }

// int SumDiag(int[,] array)
// {
// int summDiag = 0;
// int iMin = array.GetLength(1);
// if (iMin > array.GetLength(0)) iMin = array.GetLength(0);

// for (int j = 0; j < iMin; j++)
// {
//     summDiag += array[j,j];
// }
// return summDiag;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine($"Среднее арифметическое =" SumMainDiagonal(matrix)/SumDiag(matrix));

