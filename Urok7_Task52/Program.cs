// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j], 4}");
        }
        System.Console.WriteLine();
    }
}

float[] ColumnAverage (int[,]array)
{
    float[] averageArray = new float [array.GetLength(1)];
     
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           averageArray[i] += array[j, i]; 
        if (j == array.GetLength(1)-1) 
        System.Console.Write($"  {Math.Round(averageArray[i]/((byte)array.GetLength(1)), 1)}");
        }
    }
    return averageArray;   
   
}
//void PrintColumnAverage (float[] averageArray)
//{
//    for (int i = 0; i < averageArray.Length; i++)
//    {
//        System.Console.Write(averageArray[i] + " ");
//    }
//    System.Console.WriteLine();
//}

int[,] array = new int[5, 5];
FillArray (array);
PrintArray (array);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
ColumnAverage (array);
