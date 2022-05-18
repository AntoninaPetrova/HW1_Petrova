// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// 6 4 1 9
// 4 9 1 2
// ->
// 9 6 4 1
// 9 4 2 1

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void SortRow(int[,] sortArray)
{

    for (int i = 0; i < sortArray.GetLength(0); i++)
        for (int j = 0; j < sortArray.GetLength(1); j++)
        {
            for (int k = 0; k < sortArray.GetLength(1) - j - 1; k++)
            {
                if (sortArray[i, k] < sortArray[i, k + 1])

                {
                    int help = sortArray[i, k];
                    sortArray[i, k] = sortArray[i, k + 1];
                    sortArray[i, k + 1] = help;

                }

            }

        }
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SortRow(array);
System.Console.WriteLine("Упорядоченный массив по строкам по убыванию: ");
PrintArray(array);