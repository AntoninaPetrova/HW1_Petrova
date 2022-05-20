//Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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


int[,] Multiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
FillArray(array1);
FillArray(array2);
System.Console.WriteLine("Первая матрица:");
PrintArray(array1);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
PrintArray(array2);
System.Console.WriteLine();

int[,] array3 = Multiplication(array1, array2);
System.Console.WriteLine("Произведение матриц:");
PrintArray(array3);