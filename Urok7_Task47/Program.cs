﻿// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
            array[i,j] = new Random().NextDouble()*10;
        
        }
    }
}

void PrintArray(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //System.Console.Write($"{array[i,j], 4}");
            Console.Write("{0,6:F1}", array[i, j]);
           
        }
        System.Console.WriteLine();
    }
}

double[,] array1 = new double[3, 4];
FillArray(array1);
PrintArray(array1);